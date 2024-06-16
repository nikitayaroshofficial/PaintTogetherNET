using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTogetherNET
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatnipDatabase.appClosing = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            CatnipDatabase.hasServer = true;
            CatnipDatabase.wsman.BuildServer();
            CatnipDatabase.wsman.server.Start();
            loggingBehaviour.Start();
            loggingBehaviour.Enabled = true;
        }

        private void loggingBehaviour_Tick(object sender, EventArgs e)
        {
            if (CatnipDatabase.shouldUpdateLogMon)
            {
                serverLog.AppendText("\r\n" + CatnipDatabase.currentLogMonString);
                CatnipDatabase.shouldUpdateLogMon = false;
            }
        }

        private void shutdownServer_Click(object sender, EventArgs e)
        {
            CatnipDatabase.hasServer = false;
            this.Hide();
            CatnipDatabase.wsman.server.Stop(1001, serverShutdownReason.Text);
            CatnipDatabase.loadMainMenu = true;
        }

        private void kickAll_Click(object sender, EventArgs e)
        {
        }

        private void pauseDrawing_CheckedChanged(object sender, EventArgs e)
        {
            CatnipDatabase.drawEnabled = !pauseDrawing.Checked;
        }

        private void chatEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CatnipDatabase.chatEnabled = chatEnabled.Checked;
        }

        private void allowNewConnections_CheckedChanged(object sender, EventArgs e)
        {
            CatnipDatabase.connectionAllowed = allowNewConnections.Checked;
        }
    }
}
