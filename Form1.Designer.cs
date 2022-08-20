
namespace BinanceAPI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExchangesTabGroup = new System.Windows.Forms.TabControl();
            this.BinanceTab = new System.Windows.Forms.TabPage();
            this.BinanceLog = new System.Windows.Forms.TextBox();
            this.KuCoinTab = new System.Windows.Forms.TabPage();
            this.KuCoinLog = new System.Windows.Forms.TextBox();
            this.HuobiTab = new System.Windows.Forms.TabPage();
            this.HuobiLog = new System.Windows.Forms.TextBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.ExchangesTabGroup.SuspendLayout();
            this.BinanceTab.SuspendLayout();
            this.KuCoinTab.SuspendLayout();
            this.HuobiTab.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExchangesTabGroup
            // 
            this.ExchangesTabGroup.Controls.Add(this.BinanceTab);
            this.ExchangesTabGroup.Controls.Add(this.KuCoinTab);
            this.ExchangesTabGroup.Controls.Add(this.HuobiTab);
            this.ExchangesTabGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExchangesTabGroup.Location = new System.Drawing.Point(0, 0);
            this.ExchangesTabGroup.Name = "ExchangesTabGroup";
            this.ExchangesTabGroup.SelectedIndex = 0;
            this.ExchangesTabGroup.Size = new System.Drawing.Size(632, 450);
            this.ExchangesTabGroup.TabIndex = 0;
            // 
            // BinanceTab
            // 
            this.BinanceTab.Controls.Add(this.BinanceLog);
            this.BinanceTab.Location = new System.Drawing.Point(4, 24);
            this.BinanceTab.Name = "BinanceTab";
            this.BinanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.BinanceTab.Size = new System.Drawing.Size(624, 422);
            this.BinanceTab.TabIndex = 0;
            this.BinanceTab.Text = "Binance";
            this.BinanceTab.UseVisualStyleBackColor = true;
            // 
            // BinanceLog
            // 
            this.BinanceLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BinanceLog.Location = new System.Drawing.Point(3, 3);
            this.BinanceLog.Multiline = true;
            this.BinanceLog.Name = "BinanceLog";
            this.BinanceLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BinanceLog.Size = new System.Drawing.Size(618, 416);
            this.BinanceLog.TabIndex = 0;
            // 
            // KuCoinTab
            // 
            this.KuCoinTab.Controls.Add(this.KuCoinLog);
            this.KuCoinTab.Location = new System.Drawing.Point(4, 24);
            this.KuCoinTab.Name = "KuCoinTab";
            this.KuCoinTab.Padding = new System.Windows.Forms.Padding(3);
            this.KuCoinTab.Size = new System.Drawing.Size(624, 422);
            this.KuCoinTab.TabIndex = 1;
            this.KuCoinTab.Text = "KuCoin";
            this.KuCoinTab.UseVisualStyleBackColor = true;
            // 
            // KuCoinLog
            // 
            this.KuCoinLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KuCoinLog.Location = new System.Drawing.Point(3, 3);
            this.KuCoinLog.Multiline = true;
            this.KuCoinLog.Name = "KuCoinLog";
            this.KuCoinLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KuCoinLog.Size = new System.Drawing.Size(618, 416);
            this.KuCoinLog.TabIndex = 0;
            // 
            // HuobiTab
            // 
            this.HuobiTab.Controls.Add(this.HuobiLog);
            this.HuobiTab.Location = new System.Drawing.Point(4, 24);
            this.HuobiTab.Name = "HuobiTab";
            this.HuobiTab.Size = new System.Drawing.Size(624, 422);
            this.HuobiTab.TabIndex = 2;
            this.HuobiTab.Text = "Huobi";
            this.HuobiTab.UseVisualStyleBackColor = true;
            // 
            // HuobiLog
            // 
            this.HuobiLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HuobiLog.Location = new System.Drawing.Point(0, 0);
            this.HuobiLog.Multiline = true;
            this.HuobiLog.Name = "HuobiLog";
            this.HuobiLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HuobiLog.Size = new System.Drawing.Size(624, 422);
            this.HuobiLog.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoSize = true;
            this.ControlPanel.Controls.Add(this.DatabaseLabel);
            this.ControlPanel.Controls.Add(this.ConnectButton);
            this.ControlPanel.Controls.Add(this.PauseButton);
            this.ControlPanel.Controls.Add(this.StartButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(632, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(168, 450);
            this.ControlPanel.TabIndex = 1;
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButton.AutoSize = true;
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(-1, 29);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(169, 25);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(0, 0);
            this.StartButton.Margin = new System.Windows.Forms.Padding(20, 20, 20, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(168, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(2, 415);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(166, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect database";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(6, 386);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(29, 15);
            this.DatabaseLabel.TabIndex = 3;
            this.DatabaseLabel.Text = "N/A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.ExchangesTabGroup);
            this.Name = "MainForm";
            this.Text = "Coin Exchanges";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ExchangesTabGroup.ResumeLayout(false);
            this.BinanceTab.ResumeLayout(false);
            this.BinanceTab.PerformLayout();
            this.KuCoinTab.ResumeLayout(false);
            this.KuCoinTab.PerformLayout();
            this.HuobiTab.ResumeLayout(false);
            this.HuobiTab.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ExchangesTabGroup;
        private System.Windows.Forms.TabPage BinanceTab;
        private System.Windows.Forms.TabPage KuCoinTab;
        private System.Windows.Forms.TabPage HuobiTab;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox BinanceLog;
        private System.Windows.Forms.TextBox KuCoinLog;
        private System.Windows.Forms.TextBox HuobiLog;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Button ConnectButton;
    }
}

