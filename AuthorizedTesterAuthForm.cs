using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTogetherNET
{
    public partial class AuthorizedTesterAuthForm : Form
    {
        class CatnipAuthData
        {
            public string username { get; set; }
            public string token { get; set; }
        }
        public AuthorizedTesterAuthForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CatnipDatabase.appClosing = true;
        }

        private void AuthorizedTesterAuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatnipDatabase.appClosing = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string password = textBox2.Text;
            
            MD5 md5 = MD5.Create();
            byte[] passhash = (md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)));
            StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < passhash.Length; i++)
            {
                 sb.Append(passhash[i].ToString("X2"));
             }
            string passmd5 = sb.ToString();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://nikitayarosh.6te.net/yaroshium/ta.php?uname=" + uname + "&token=" + passmd5);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            if (content == "ok")
            {
                //MessageBox.Show(passmd5);
                string toWrite = "";
                toWrite += "CATNIPTA";
                CatnipAuthData cad = new CatnipAuthData();
                cad.username = uname;
                cad.token = passmd5;
                toWrite += Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(JsonSerializer.Serialize(cad)));
                //MessageBox.Show(toWrite);
                StreamWriter sw = new StreamWriter("testerauth.catnip");
                sw.Write(toWrite);
                sw.Close();
                MessageBox.Show("Данные записаны, доступ получен! Перезапустите приложение.");
                CatnipDatabase.appClosing = true;
            }
            else
            {
                MessageBox.Show("Ошибка авторизации! Код ошибки: catnipAuth." + content + "\nПройдите авторизацию заново.");
            }
            
        }
    }
}
