using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsServiceRabbitMQ
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        Thread trd;
        private static readonly string _queueName = "ZEYNEPOZTURKMEN";
        private static Consumer _consumer;

        protected override void OnStart(string[] args)
        {
            trd = new Thread(new ThreadStart(WriteToFile));
            trd.IsBackground = false;
            trd.Start();
        }
        public void WriteToFile()
        {
            while (true)
            {
                _consumer = new Consumer(_queueName);

                Thread.Sleep(2000);
            }
        }
        protected override void OnStop()
        {
        }
    }
}
