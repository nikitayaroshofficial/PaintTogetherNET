using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTogetherNET
{
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
        }
        public class PublicServer
        {
            public PublicServer(string addr, string desc, string defaultUsername, string defaultPassword) {
                this.addr = addr;
                this.desc = desc;
                this.defaultUsername = defaultUsername;
                this.defaultPassword = defaultPassword;
            }
            public string addr { get; set; }
            public string desc { get; set; }
            public string defaultUsername { get; set; }
            public string defaultPassword { get; set; }
            public ConnectedToServer ToCatnip() {
                ConnectedToServer ret = new ConnectedToServer();
                ret.addr = this.addr;
                ret.desc = this.desc;
                ret.un = this.defaultUsername;
                ret.up = this.defaultPassword;
                return ret;
            }
        }
        public class PublicServerList
        {
            public PublicServerList()
            {
            }
            public PublicServerList(PublicServer[] servers)
            {
                this.servers = servers;
            }
            public PublicServer[] servers { get; set; }
        }
        public class AuthDataPass
        {
            public AuthDataPass(string uname, string password)
            {
                this.uname = uname;
                this.password = password;
            }
            string uname { get; set; }
            string password { get; set; }
        }
        PublicServerList psl = new PublicServerList();
        private void JoinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatnipDatabase.appClosing = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void JoinForm_Load(object sender, EventArgs e)
        {
            try
            {
                publicServersLb.Items.Clear();
                string serversJson = CatnipDatabase.wsman.getHTTP(publicServerListAddrEdit.Text);
                psl = JsonSerializer.Deserialize<PublicServerList>(serversJson);
                foreach (PublicServer svd in psl.servers)
                {
                    try
                    {
                        publicServersLb.Items.Add(svd.desc);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка обработки сервера");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось получить список серверов по данному адресу.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            CatnipDatabase.appClosing = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                publicServersLb.Items.Clear();
                string serversJson = CatnipDatabase.wsman.getHTTP(publicServerListAddrEdit.Text);
                psl = JsonSerializer.Deserialize<PublicServerList>(serversJson);
                foreach (PublicServer svd in psl.servers)
                {
                    try
                    {
                        publicServersLb.Items.Add(svd.desc);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка обработки сервера");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось получить список серверов по данному адресу.");
            }
        }

        private void publicServersLb_Click(object sender, EventArgs e)
        {
            //stupid; removed
        }

        private void savePublicBtn_Click(object sender, EventArgs e)
        {
            PublicServer ss = psl.servers[publicServersLb.SelectedIndex];
            serverNickname.Text = ss.desc;
            serverIpAddr.Text = ss.addr;
            if (saveServerUsername != null)
            {
                provideAuthDetails.Checked = true;
                saveServerUsername.Text = ss.defaultUsername;
                saveServerPassword.Text = ss.defaultPassword;
            }
            else
            {
                provideAuthDetails.Checked = false;
            }
        }

        private void connectToPublicBtn_Click(object sender, EventArgs e)
        {
            PublicServer ss = psl.servers[publicServersLb.SelectedIndex];
            CatnipDatabase.hasClient = true;
            CatnipDatabase.connection = ss.ToCatnip();
            CatnipDatabase.wsman.Connect(ss.addr);
            /*CatnipDatabase.wsman.receiver.OnError += (tsend,te) =>
            {
                MessageBox.Show("При попытке установить соединение с сервером произошла ошибка.","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            CatnipDatabase.wsman.receiver.OnClose += (tsend, te) =>
            {
                MessageBox.Show("При попытке установить соединение с сервером произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };*/
            ClientForm frm = new ClientForm();
            frm.Show();
            this.Hide();
            /*CatnipDatabase.wsman.receiver.OnOpen += (tsend, te) =>
            {
                ClientForm frm = new ClientForm();
                frm.Show();
                this.Hide();
            };*/
            
            
        }

        private void publicServersLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PublicServer ss = psl.servers[publicServersLb.SelectedIndex];
                publicServerDescription.Text = "Публичный сервер";
                publicServerDescription.Text += "\r\nИмя сервера: " + ss.desc;
                publicServerDescription.Text += "\r\nАдрес сервера: " + ss.addr;
                //publicServerDescription.Text += "\r\nПубличная авторизация";
                //publicServerDescription.Text += "\r\nПользователь: " + ss.defaultUsername;
                //publicServerDescription.Text += "\r\nПароль: " + ss.defaultPassword;
                savePublicBtn.Enabled = true;
                connectToPublicBtn.Enabled = true;
            }
            catch
            {

            }
        }
        private void authBegin(string username, string password)
        {
            CatnipDatabase.wsman.receiver.Send(JsonSerializer.Serialize<AuthDataPass>(new AuthDataPass(username,password)));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatnipDatabase.loadMainMenu = true;
        }
    }
}
