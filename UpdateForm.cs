using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PaintTogetherNET.Form1;

namespace PaintTogetherNET
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        string gotoLink = "";
        UpdateData uds;
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            try
            {
                string ud = CatnipDatabase.wsman.getHTTP("http://nikitayarosh.6te.net/paintTogether/version.json");
                uds = JsonSerializer.Deserialize<UpdateData>(ud);
                latestVersion.Text = CatnipDatabase.CURRENT_VERSION +" => "+ uds.latestVersion;
                updateList.Items.Clear();
                foreach(var item in uds.downloadTitleList)
                {
                    updateList.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Произошла внутренняя ошибка. Сообщите разработчику этот код: UPDATEFORM_LOADDATA_CRITICALFAILURE");
                this.Close();
            }
        }

        private void updateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            goDownload.Enabled = true;
            gotoLink = uds.downloadLinkList[updateList.SelectedIndex];
        }
        public bool WarnUserAboutVersionDifference()
        {
            DialogResult ua = MessageBox.Show("Внимание! При различии версий сервера и клиента могут возникнуть ошибки совместимости, поэтому настоятельно рекомендуется обновить клиент. Всё равно продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            return (ua == DialogResult.Yes);
        }
        private void remindLater_Click(object sender, EventArgs e)
        {
            if (WarnUserAboutVersionDifference())
            {
                this.Close();
            }
            
        }

        private void goDownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(gotoLink);
            CatnipDatabase.appClosing = true;
        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!WarnUserAboutVersionDifference())
            {
                e.Cancel = true;
            }
        }
    }
}
