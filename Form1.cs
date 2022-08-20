using BinanceAPI.db;
using BinanceAPI.services;
using BinanceAPI.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceAPI
{
    public partial class MainForm : Form
    {
        List<ExchangeService> m_cryptoExchanges = new() { new BinanceService(), new KucoinService() };

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LogToForm.Instance.Init(ProcessMessage);
        }

        private void ProcessMessage(Msg msg)
        {
            string message =
                $"[{DateTime.Now.ToString("hh:mm:ss")}]\t{msg.Source.PadLeft(15, '-')}\t{msg.Content}\r\n";

            Invoke(new Action(() =>
            {
                switch (msg.Type)
                {
                    case 1:
                        BinanceLog.Text = message + BinanceLog.Text;
                        break;
                    case 2:
                        KuCoinLog.Text = message + KuCoinLog.Text;
                        break;
                    case 3:
                        HuobiLog.Text = message + HuobiLog.Text;
                        break;
                }
            }));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            PauseButton.Enabled = true;
            foreach (var exchangeService in m_cryptoExchanges)
            {
                exchangeService.UpdateProductsStat();
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            PauseButton.Text = "Resume";

            foreach (var exchangeService in m_cryptoExchanges)
            {
                exchangeService.Suspend();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "SQLite database (*.db)|*.db|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    DatabaseLabel.Text = Path.GetFileName(openFileDialog.FileName);

                    foreach (var exchange in m_cryptoExchanges)
                    {
                        exchange.DatabasePath = openFileDialog.FileName;
                    }
                }
            }
        }
    }
}
