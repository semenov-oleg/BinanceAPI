using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceAPI.utils
{
    public class Msg
    {
        public int Type { get; set; }
        public string Source = "";
        public string Content = "";
        public Msg(int type, string source, string content)
        {
            Type = type;
            Source = source;
            Content = content;
        }
        public static void Send(int type, string source, string content)
        {
            LogToForm.Write(new Msg(type, source, content));
        }
    }
    class LogToForm
    {
        static Action<Msg>? m_logAction;
        public static void Write(Msg msg) => m_logAction?.Invoke(msg);

        static object _lockFlag = new object();
        static LogToForm? _instance;

        public static LogToForm Instance
        {
            get
            {
                lock (_lockFlag)
                {
                    if (_instance == null)
                        _instance = new LogToForm();
                }
                return _instance;
            }
        }
        public void Init(Action<Msg> logAction)
        {
            m_logAction = logAction;
        }
    }
}
