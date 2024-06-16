using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTogetherNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class CatnipAuthData
        {
            public string username { get; set; }
            public string token { get; set; }
        }
        public class UpdateData
        {
            public string[] downloadTitleList { get; set; }
            public string[] downloadLinkList { get; set; }
            public string latestVersion { get; set; }
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = CatnipDatabase.CURRENT_VERSION;
            bool WasSuccess = true;
            string savedataraw = "";
            CatnipAuthData userdata = new CatnipAuthData();
            try
            {
                StreamReader reader = new StreamReader("testerauth.catnip");
                savedataraw = reader.ReadToEnd();
                reader.Close();
            }
            catch
            {
                WasSuccess = false;
                }
            if (WasSuccess == true)
            {
                if (savedataraw.Substring(0, 6) == "CATNIP")
                {
                    string role = savedataraw.Substring(6, 2);
                    if (role == "TA")
                    {
                        savedataraw = savedataraw.Substring(8);
                        savedataraw = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(savedataraw));
                        userdata = JsonSerializer.Deserialize<CatnipAuthData>(savedataraw);
                        string content = CatnipDatabase.wsman.getHTTP("http://nikitayarosh.6te.net/yaroshium/ta.php?uname=" + userdata.username + "&token=" + userdata.token);
                        if (content == "ok")
                        {
                            WasSuccess = true;
                        }
                        else
                        {
                            WasSuccess = false;
                            //MessageBox.Show("Ошибка авторизации! Код ошибки: " + content + "\nПройдите авторизацию заново.");
                        }
                    }
                    else
                    {
                        WasSuccess = false;
                    }
                }
                else
                {
                    WasSuccess = false;
                }

                
            }
            if (WasSuccess)
            {
                DebugModeBtn.Enabled = true;
            }
            else
            {
                //AuthorizedTesterAuthForm ataf = new AuthorizedTesterAuthForm();
                //ataf.Show();
                //this.Enabled = false;
            }
            try
            {
                string ud = CatnipDatabase.wsman.getHTTP("http://nikitayarosh.6te.net/paintTogether/version.json");
                UpdateData uds = JsonSerializer.Deserialize<UpdateData>(ud);
                if (uds.latestVersion != CatnipDatabase.CURRENT_VERSION)
                {
                    UpdateForm frm = new UpdateForm();
                    frm.Show();
                    frm.Focus();
                }
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void DebugModeBtn_Click(object sender, EventArgs e)
        {
            DebugForm frm = new DebugForm();
            frm.Show();
            this.Hide();
        }

        private void closeBehavior_Tick(object sender, EventArgs e)
        {
            if (CatnipDatabase.appClosing)
            {
                this.Close();
            }
            if (CatnipDatabase.loadMainMenu)
            {
                this.Show();
                CatnipDatabase.loadMainMenu = false;
            }
            CatnipDatabase.init = true;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult uan = MessageBox.Show("Вы уверены?","Paint Together .NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(uan == DialogResult.Yes)
            {
                CatnipDatabase.appClosing = true;
            }
        }

        private void ServerModeBtn_Click(object sender, EventArgs e)
        {
            ServerForm frm = new ServerForm();
            frm.Show();
            this.Hide();
        }

        private void ClientModeBtn_Click(object sender, EventArgs e)
        {
            JoinForm frm = new JoinForm();
            frm.Show();
            this.Hide();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Show();
        }
    }
}
