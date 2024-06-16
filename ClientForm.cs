using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Configuration;

namespace PaintTogetherNET
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        bool mouseButton = false;
        bool mouseDown = false;
        Graphics cg;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void sendRequest(int cx, int cy)
        {
            bool doAnything = true;
            int cr, cg, cb;
            try
            {
                uint cw = Convert.ToUInt32(brushSize.Text);
            }
            catch
            {
                doAnything = false;
            }
            string action = "";
            if (mouseButton)
            {
                cr = secondaryColor.BackColor.R;
                cg = secondaryColor.BackColor.G;
                cb = secondaryColor.BackColor.B;
            }
            else
            {
                cr = primaryColor.BackColor.R;
                cg = primaryColor.BackColor.G;
                cb = primaryColor.BackColor.B;
            }
            if (rbPen.Checked)
            {
                action = "pen";
            }
            else if (rbBrush.Checked)
            {
                action = "brush";
            }
            else if (rbSpray.Checked)
            {
                action = "spray";
            }
            string rr = Convert.ToString(cr);
            string rg = Convert.ToString(cg);
            string rb = Convert.ToString(cb);
            string rx = Convert.ToString(cx);
            string ry = Convert.ToString(cy);
            string rw = brushSize.Text;
            if (doAnything)
            {
                CatnipRequest formed = new CatnipRequest(action, rx, ry, rr, rg, rb, rw);
                CatnipDatabase.wsman.receiver.Send(JsonSerializer.Serialize<CatnipRequest>(formed));
            }
        }

        private void selectPrimaryColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                primaryColor.BackColor = colorDialog1.Color;
            }
        }

        private void selectSecondaryColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                secondaryColor.BackColor = colorDialog1.Color;
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            cg = canvas.CreateGraphics();
            CatnipDatabase.wsman.receiver.OnClose+=(tsender, te) =>{
                MessageBox.Show("Соединение с сервером разорвано. Причина:\n"+te.Reason,"Соединение потеряно",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                CatnipDatabase.wsman.PrepareForReconnection();
                this.Hide();
                CatnipDatabase.loadMainMenu = true;
            };
            CatnipDatabase.wsman.receiver.OnMessage += (tsender, te) =>
            {
                CatnipRequest sd;
                sd = JsonSerializer.Deserialize<CatnipRequest>(te.Data);
                
                
                if (sd.type == "pen"|| sd.type == "brush")
                {
                    int rx = Convert.ToInt32(sd.meta1);
                    int ry = Convert.ToInt32(sd.meta2);
                    int rr = Convert.ToInt32(sd.meta3);
                    int rg = Convert.ToInt32(sd.meta4);
                    int rb = Convert.ToInt32(sd.meta5);
                    Brush p = new Pen(Color.FromArgb(rr, rg, rb)).Brush;
                    if (sd.type == "pen")
                    {
                        cg.FillRectangle(p, rx, ry, 1, 1);
                    }
                    if (sd.type == "brush")
                    {
                        int rw = Convert.ToInt32(sd.meta6);
                        cg.FillEllipse(p, rx-(rw / 2), ry - (rw / 2), rw,rw);
                    }
                }
                if(sd.type == "chat")
                {
                    CatnipDatabase.CHAT_LOG("\n<" + sd.meta1 + "> " + sd.meta2);
                }
                
                
            };
            chatLog.Text = "";
            chatBehaviour.Enabled = true;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CatnipDatabase.appClosing = true;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            if (e.Button == MouseButtons.Left)
            {
                mouseButton = false;
            }
            else if(e.Button == MouseButtons.Right)
            {
                mouseButton = true;
            }
            sendRequest(e.X, e.Y);
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                sendRequest(e.X, e.Y);
            }
        }

        private void chatSendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (chatText.Text != "")
                {
                    CatnipRequest formed = new CatnipRequest("chat", CatnipDatabase.connection.un, chatText.Text);
                    CatnipDatabase.wsman.receiver.Send(JsonSerializer.Serialize<CatnipRequest>(formed));
                    chatText.Text = "";
                }
            }
            catch{
                chatLog.Text += "\r\nПроизошла ошибка при отправке Вашего сообщения.";
            }
        }

        private void chatBehaviour_Tick(object sender, EventArgs e)
        {
            if (CatnipDatabase.shouldUpdateChat)
            {
                chatLog.Text += "\r\n" + CatnipDatabase.currentChatString;
                CatnipDatabase.shouldUpdateChat = false;
            }
        }
    }
}
