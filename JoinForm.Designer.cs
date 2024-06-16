namespace PaintTogetherNET
{
    partial class JoinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinForm));
            this.label1 = new System.Windows.Forms.Label();
            this.savedServersLb = new System.Windows.Forms.ListBox();
            this.serverIpAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverNickname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.provideAuthDetails = new System.Windows.Forms.CheckBox();
            this.saveServerUsername = new System.Windows.Forms.TextBox();
            this.saveServerPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.connectToSavedBtn = new System.Windows.Forms.Button();
            this.saveServerBtn = new System.Windows.Forms.Button();
            this.deleteSavedBtn = new System.Windows.Forms.Button();
            this.publicServersLb = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.connectToPublicBtn = new System.Windows.Forms.Button();
            this.savePublicBtn = new System.Windows.Forms.Button();
            this.publicServerDescription = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.publicServerListAddrEdit = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.replaceSavedServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сохранённые серверы";
            this.label1.Visible = false;
            // 
            // savedServersLb
            // 
            this.savedServersLb.FormattingEnabled = true;
            this.savedServersLb.Location = new System.Drawing.Point(12, 25);
            this.savedServersLb.Name = "savedServersLb";
            this.savedServersLb.Size = new System.Drawing.Size(354, 199);
            this.savedServersLb.TabIndex = 1;
            this.savedServersLb.Visible = false;
            // 
            // serverIpAddr
            // 
            this.serverIpAddr.Location = new System.Drawing.Point(375, 80);
            this.serverIpAddr.Name = "serverIpAddr";
            this.serverIpAddr.Size = new System.Drawing.Size(306, 20);
            this.serverIpAddr.TabIndex = 2;
            this.serverIpAddr.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP-адрес сервера";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Псевдоним сервера в списке";
            this.label5.Visible = false;
            // 
            // serverNickname
            // 
            this.serverNickname.Location = new System.Drawing.Point(375, 41);
            this.serverNickname.Name = "serverNickname";
            this.serverNickname.Size = new System.Drawing.Size(306, 20);
            this.serverNickname.TabIndex = 8;
            this.serverNickname.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Имя пользователя";
            this.label6.Visible = false;
            // 
            // provideAuthDetails
            // 
            this.provideAuthDetails.AutoSize = true;
            this.provideAuthDetails.Location = new System.Drawing.Point(375, 106);
            this.provideAuthDetails.Name = "provideAuthDetails";
            this.provideAuthDetails.Size = new System.Drawing.Size(199, 17);
            this.provideAuthDetails.TabIndex = 10;
            this.provideAuthDetails.Text = "Указать данные для авторизации";
            this.provideAuthDetails.UseVisualStyleBackColor = true;
            this.provideAuthDetails.Visible = false;
            // 
            // saveServerUsername
            // 
            this.saveServerUsername.Location = new System.Drawing.Point(375, 142);
            this.saveServerUsername.Name = "saveServerUsername";
            this.saveServerUsername.Size = new System.Drawing.Size(306, 20);
            this.saveServerUsername.TabIndex = 11;
            this.saveServerUsername.Visible = false;
            // 
            // saveServerPassword
            // 
            this.saveServerPassword.Location = new System.Drawing.Point(375, 179);
            this.saveServerPassword.Name = "saveServerPassword";
            this.saveServerPassword.PasswordChar = '•';
            this.saveServerPassword.Size = new System.Drawing.Size(306, 20);
            this.saveServerPassword.TabIndex = 13;
            this.saveServerPassword.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пароль";
            this.label7.Visible = false;
            // 
            // connectToSavedBtn
            // 
            this.connectToSavedBtn.Location = new System.Drawing.Point(375, 205);
            this.connectToSavedBtn.Name = "connectToSavedBtn";
            this.connectToSavedBtn.Size = new System.Drawing.Size(92, 23);
            this.connectToSavedBtn.TabIndex = 14;
            this.connectToSavedBtn.Text = "Подключиться";
            this.connectToSavedBtn.UseVisualStyleBackColor = true;
            this.connectToSavedBtn.Visible = false;
            // 
            // saveServerBtn
            // 
            this.saveServerBtn.Location = new System.Drawing.Point(473, 205);
            this.saveServerBtn.Name = "saveServerBtn";
            this.saveServerBtn.Size = new System.Drawing.Size(69, 23);
            this.saveServerBtn.TabIndex = 15;
            this.saveServerBtn.Text = "Добавить";
            this.saveServerBtn.UseVisualStyleBackColor = true;
            this.saveServerBtn.Visible = false;
            // 
            // deleteSavedBtn
            // 
            this.deleteSavedBtn.Location = new System.Drawing.Point(548, 205);
            this.deleteSavedBtn.Name = "deleteSavedBtn";
            this.deleteSavedBtn.Size = new System.Drawing.Size(62, 23);
            this.deleteSavedBtn.TabIndex = 16;
            this.deleteSavedBtn.Text = "Удалить";
            this.deleteSavedBtn.UseVisualStyleBackColor = true;
            this.deleteSavedBtn.Visible = false;
            // 
            // publicServersLb
            // 
            this.publicServersLb.FormattingEnabled = true;
            this.publicServersLb.Location = new System.Drawing.Point(12, 269);
            this.publicServersLb.Name = "publicServersLb";
            this.publicServersLb.Size = new System.Drawing.Size(354, 173);
            this.publicServersLb.TabIndex = 17;
            this.publicServersLb.Click += new System.EventHandler(this.publicServersLb_Click);
            this.publicServersLb.SelectedIndexChanged += new System.EventHandler(this.publicServersLb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Публичные серверы";
            // 
            // connectToPublicBtn
            // 
            this.connectToPublicBtn.Enabled = false;
            this.connectToPublicBtn.Location = new System.Drawing.Point(375, 419);
            this.connectToPublicBtn.Name = "connectToPublicBtn";
            this.connectToPublicBtn.Size = new System.Drawing.Size(155, 23);
            this.connectToPublicBtn.TabIndex = 19;
            this.connectToPublicBtn.Text = "Подключиться";
            this.connectToPublicBtn.UseVisualStyleBackColor = true;
            this.connectToPublicBtn.Click += new System.EventHandler(this.connectToPublicBtn_Click);
            // 
            // savePublicBtn
            // 
            this.savePublicBtn.Enabled = false;
            this.savePublicBtn.Location = new System.Drawing.Point(536, 419);
            this.savePublicBtn.Name = "savePublicBtn";
            this.savePublicBtn.Size = new System.Drawing.Size(146, 23);
            this.savePublicBtn.TabIndex = 20;
            this.savePublicBtn.Text = "Подставить в форму";
            this.savePublicBtn.UseVisualStyleBackColor = true;
            this.savePublicBtn.Visible = false;
            this.savePublicBtn.Click += new System.EventHandler(this.savePublicBtn_Click);
            // 
            // publicServerDescription
            // 
            this.publicServerDescription.Location = new System.Drawing.Point(375, 243);
            this.publicServerDescription.Multiline = true;
            this.publicServerDescription.Name = "publicServerDescription";
            this.publicServerDescription.ReadOnly = true;
            this.publicServerDescription.Size = new System.Drawing.Size(306, 170);
            this.publicServerDescription.TabIndex = 21;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 448);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(92, 23);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // publicServerListAddrEdit
            // 
            this.publicServerListAddrEdit.Location = new System.Drawing.Point(12, 243);
            this.publicServerListAddrEdit.Name = "publicServerListAddrEdit";
            this.publicServerListAddrEdit.Size = new System.Drawing.Size(324, 20);
            this.publicServerListAddrEdit.TabIndex = 23;
            this.publicServerListAddrEdit.Text = "http://nikitayarosh.6te.net/paintTogether/serverList.json";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(110, 448);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 23);
            this.exitButton.TabIndex = 24;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(342, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "q";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // replaceSavedServer
            // 
            this.replaceSavedServer.Location = new System.Drawing.Point(616, 205);
            this.replaceSavedServer.Name = "replaceSavedServer";
            this.replaceSavedServer.Size = new System.Drawing.Size(65, 23);
            this.replaceSavedServer.TabIndex = 26;
            this.replaceSavedServer.Text = "Заменить";
            this.replaceSavedServer.UseVisualStyleBackColor = true;
            this.replaceSavedServer.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(294, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Скоро...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Внимание! Тестовая версия!\r\nСинхронизации пикселей при входе на сервер пока нет";
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.replaceSavedServer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publicServerListAddrEdit);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.publicServerDescription);
            this.Controls.Add(this.savePublicBtn);
            this.Controls.Add(this.connectToPublicBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.publicServersLb);
            this.Controls.Add(this.deleteSavedBtn);
            this.Controls.Add(this.saveServerBtn);
            this.Controls.Add(this.connectToSavedBtn);
            this.Controls.Add(this.saveServerPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveServerUsername);
            this.Controls.Add(this.provideAuthDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serverNickname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverIpAddr);
            this.Controls.Add(this.savedServersLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JoinForm";
            this.Text = "Paint Together DotNET - Подключение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JoinForm_FormClosing);
            this.Load += new System.EventHandler(this.JoinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox savedServersLb;
        private System.Windows.Forms.TextBox serverIpAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox serverNickname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox provideAuthDetails;
        private System.Windows.Forms.TextBox saveServerUsername;
        private System.Windows.Forms.TextBox saveServerPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button connectToSavedBtn;
        private System.Windows.Forms.Button saveServerBtn;
        private System.Windows.Forms.Button deleteSavedBtn;
        private System.Windows.Forms.ListBox publicServersLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button connectToPublicBtn;
        private System.Windows.Forms.Button savePublicBtn;
        private System.Windows.Forms.TextBox publicServerDescription;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox publicServerListAddrEdit;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button replaceSavedServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}