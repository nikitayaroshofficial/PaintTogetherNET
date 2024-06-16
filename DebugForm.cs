using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTogetherNET
{

    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        private void DebugForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatnipDatabase.appClosing = true;
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            CatnipDatabase.wsman.Connect("127.0.0.1");
            CatnipDatabase.wsman.receiver.OnOpen += (tsender, te) =>
            {
                this.logMon.Text += "\r\nSVCONNECTED";
            };
            CatnipDatabase.wsman.receiver.OnMessage += (tsender, te) =>
            {
                CatnipDatabase.DEBUG_UPDATE_LOGS(te.Data);
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CatnipDatabase.wsman.receiver.Send("test");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CatnipDatabase.wsman.BuildServer();
            CatnipDatabase.wsman.server.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (CatnipDatabase.shouldUpdateLogMon)
                {
                    logMon.Text += "\r\n" + CatnipDatabase.currentLogMonString;
                    CatnipDatabase.shouldUpdateLogMon = false;
                }
            }
            catch
            {
                logMon.Text += "\r\nWarning! The LogUpdate routine has been stopped due to an exception occured in process.";
                timer1.Enabled = false;
            }
        }
    }
}
