namespace PaintTogetherNET
{
    partial class ServerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.serverLog = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.shutdownServer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearLogBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullUserList = new System.Windows.Forms.ListBox();
            this.onlineUserList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kickAll = new System.Windows.Forms.Button();
            this.serverShutdownReason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.viewBanInfo = new System.Windows.Forms.Button();
            this.unbanUser = new System.Windows.Forms.Button();
            this.unbanField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteUserAccountBtn = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.administratingNewPassword = new System.Windows.Forms.TextBox();
            this.applyAdministratingChanges = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.administratingUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.banUserIPBtn = new System.Windows.Forms.Button();
            this.banUserBtn = new System.Windows.Forms.Button();
            this.disconnectUserBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clearCreateAccountForm = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.createAccountPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.createAcoountUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.allowNewConnections = new System.Windows.Forms.CheckBox();
            this.chatEnabled = new System.Windows.Forms.CheckBox();
            this.pauseDrawing = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serverMessage = new System.Windows.Forms.TextBox();
            this.sendServerMessage = new System.Windows.Forms.Button();
            this.loggingBehaviour = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverLog
            // 
            this.serverLog.Location = new System.Drawing.Point(6, 19);
            this.serverLog.Multiline = true;
            this.serverLog.Name = "serverLog";
            this.serverLog.ReadOnly = true;
            this.serverLog.Size = new System.Drawing.Size(1016, 329);
            this.serverLog.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(10, 511);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // shutdownServer
            // 
            this.shutdownServer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.shutdownServer.ForeColor = System.Drawing.Color.Red;
            this.shutdownServer.Location = new System.Drawing.Point(6, 96);
            this.shutdownServer.Name = "shutdownServer";
            this.shutdownServer.Size = new System.Drawing.Size(269, 23);
            this.shutdownServer.TabIndex = 3;
            this.shutdownServer.Text = "Завершить работу сервера";
            this.shutdownServer.UseVisualStyleBackColor = false;
            this.shutdownServer.Click += new System.EventHandler(this.shutdownServer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearLogBtn);
            this.groupBox1.Controls.Add(this.serverLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 387);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лог сервера";
            // 
            // clearLogBtn
            // 
            this.clearLogBtn.Location = new System.Drawing.Point(6, 353);
            this.clearLogBtn.Name = "clearLogBtn";
            this.clearLogBtn.Size = new System.Drawing.Size(1016, 29);
            this.clearLogBtn.TabIndex = 2;
            this.clearLogBtn.Text = "Очистить лог";
            this.clearLogBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пользователи";
            // 
            // fullUserList
            // 
            this.fullUserList.FormattingEnabled = true;
            this.fullUserList.Location = new System.Drawing.Point(892, 618);
            this.fullUserList.Name = "fullUserList";
            this.fullUserList.Size = new System.Drawing.Size(154, 368);
            this.fullUserList.TabIndex = 6;
            // 
            // onlineUserList
            // 
            this.onlineUserList.FormattingEnabled = true;
            this.onlineUserList.Location = new System.Drawing.Point(1052, 618);
            this.onlineUserList.Name = "onlineUserList";
            this.onlineUserList.Size = new System.Drawing.Size(154, 368);
            this.onlineUserList.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1052, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "В сети";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kickAll);
            this.groupBox2.Controls.Add(this.serverShutdownReason);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.shutdownServer);
            this.groupBox2.Location = new System.Drawing.Point(758, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Завершение работы";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // kickAll
            // 
            this.kickAll.Location = new System.Drawing.Point(6, 67);
            this.kickAll.Name = "kickAll";
            this.kickAll.Size = new System.Drawing.Size(269, 23);
            this.kickAll.TabIndex = 6;
            this.kickAll.Text = "Отсоединить всех";
            this.kickAll.UseVisualStyleBackColor = true;
            this.kickAll.Visible = false;
            this.kickAll.Click += new System.EventHandler(this.kickAll_Click);
            // 
            // serverShutdownReason
            // 
            this.serverShutdownReason.Location = new System.Drawing.Point(6, 41);
            this.serverShutdownReason.Name = "serverShutdownReason";
            this.serverShutdownReason.Size = new System.Drawing.Size(269, 20);
            this.serverShutdownReason.TabIndex = 5;
            this.serverShutdownReason.Text = "Техническое обслуживание сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Причина завершения работы:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.viewBanInfo);
            this.groupBox4.Controls.Add(this.unbanUser);
            this.groupBox4.Controls.Add(this.unbanField);
            this.groupBox4.Location = new System.Drawing.Point(617, 599);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 101);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Снятие блокировок";
            this.groupBox4.Visible = false;
            // 
            // viewBanInfo
            // 
            this.viewBanInfo.Location = new System.Drawing.Point(3, 45);
            this.viewBanInfo.Name = "viewBanInfo";
            this.viewBanInfo.Size = new System.Drawing.Size(260, 23);
            this.viewBanInfo.TabIndex = 12;
            this.viewBanInfo.Text = "Просмотреть информацию";
            this.viewBanInfo.UseVisualStyleBackColor = true;
            // 
            // unbanUser
            // 
            this.unbanUser.Location = new System.Drawing.Point(3, 74);
            this.unbanUser.Name = "unbanUser";
            this.unbanUser.Size = new System.Drawing.Size(260, 23);
            this.unbanUser.TabIndex = 11;
            this.unbanUser.Text = "Разблокировать";
            this.unbanUser.UseVisualStyleBackColor = true;
            // 
            // unbanField
            // 
            this.unbanField.Location = new System.Drawing.Point(6, 19);
            this.unbanField.Name = "unbanField";
            this.unbanField.Size = new System.Drawing.Size(260, 20);
            this.unbanField.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteUserAccountBtn);
            this.groupBox3.Controls.Add(this.showPassword);
            this.groupBox3.Controls.Add(this.administratingNewPassword);
            this.groupBox3.Controls.Add(this.applyAdministratingChanges);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.administratingUsername);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.banUserIPBtn);
            this.groupBox3.Controls.Add(this.banUserBtn);
            this.groupBox3.Controls.Add(this.disconnectUserBtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.reasonBox);
            this.groupBox3.Location = new System.Drawing.Point(326, 599);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 284);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пользователь";
            this.groupBox3.Visible = false;
            // 
            // deleteUserAccountBtn
            // 
            this.deleteUserAccountBtn.Location = new System.Drawing.Point(3, 251);
            this.deleteUserAccountBtn.Name = "deleteUserAccountBtn";
            this.deleteUserAccountBtn.Size = new System.Drawing.Size(260, 23);
            this.deleteUserAccountBtn.TabIndex = 11;
            this.deleteUserAccountBtn.Text = "Удалить аккаунт навсегда";
            this.deleteUserAccountBtn.UseVisualStyleBackColor = true;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(3, 97);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(114, 17);
            this.showPassword.TabIndex = 10;
            this.showPassword.Text = "Показать пароль";
            this.showPassword.UseVisualStyleBackColor = true;
            // 
            // administratingNewPassword
            // 
            this.administratingNewPassword.Location = new System.Drawing.Point(3, 71);
            this.administratingNewPassword.Name = "administratingNewPassword";
            this.administratingNewPassword.PasswordChar = '•';
            this.administratingNewPassword.Size = new System.Drawing.Size(260, 20);
            this.administratingNewPassword.TabIndex = 9;
            // 
            // applyAdministratingChanges
            // 
            this.applyAdministratingChanges.Location = new System.Drawing.Point(188, 93);
            this.applyAdministratingChanges.Name = "applyAdministratingChanges";
            this.applyAdministratingChanges.Size = new System.Drawing.Size(75, 23);
            this.applyAdministratingChanges.TabIndex = 8;
            this.applyAdministratingChanges.Text = "Применить";
            this.applyAdministratingChanges.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Новый пароль:";
            // 
            // administratingUsername
            // 
            this.administratingUsername.Location = new System.Drawing.Point(3, 32);
            this.administratingUsername.Name = "administratingUsername";
            this.administratingUsername.ReadOnly = true;
            this.administratingUsername.Size = new System.Drawing.Size(260, 20);
            this.administratingUsername.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Управление пользователем:";
            // 
            // banUserIPBtn
            // 
            this.banUserIPBtn.Location = new System.Drawing.Point(3, 222);
            this.banUserIPBtn.Name = "banUserIPBtn";
            this.banUserIPBtn.Size = new System.Drawing.Size(260, 23);
            this.banUserIPBtn.TabIndex = 4;
            this.banUserIPBtn.Text = "Заблокировать IP";
            this.banUserIPBtn.UseVisualStyleBackColor = true;
            // 
            // banUserBtn
            // 
            this.banUserBtn.Location = new System.Drawing.Point(3, 193);
            this.banUserBtn.Name = "banUserBtn";
            this.banUserBtn.Size = new System.Drawing.Size(260, 23);
            this.banUserBtn.TabIndex = 3;
            this.banUserBtn.Text = "Заблокировать";
            this.banUserBtn.UseVisualStyleBackColor = true;
            // 
            // disconnectUserBtn
            // 
            this.disconnectUserBtn.Location = new System.Drawing.Point(3, 164);
            this.disconnectUserBtn.Name = "disconnectUserBtn";
            this.disconnectUserBtn.Size = new System.Drawing.Size(260, 23);
            this.disconnectUserBtn.TabIndex = 2;
            this.disconnectUserBtn.Text = "Отсоединить";
            this.disconnectUserBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Причина:";
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(3, 138);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(260, 20);
            this.reasonBox.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(91, 511);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clearCreateAccountForm);
            this.groupBox5.Controls.Add(this.createAccount);
            this.groupBox5.Controls.Add(this.createAccountPassword);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.createAcoountUsername);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 583);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 129);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Создание аккаунта";
            this.groupBox5.Visible = false;
            // 
            // clearCreateAccountForm
            // 
            this.clearCreateAccountForm.Location = new System.Drawing.Point(9, 100);
            this.clearCreateAccountForm.Name = "clearCreateAccountForm";
            this.clearCreateAccountForm.Size = new System.Drawing.Size(145, 23);
            this.clearCreateAccountForm.TabIndex = 5;
            this.clearCreateAccountForm.Text = "Очистить форму";
            this.clearCreateAccountForm.UseVisualStyleBackColor = true;
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(163, 100);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(145, 23);
            this.createAccount.TabIndex = 4;
            this.createAccount.Text = "Создать";
            this.createAccount.UseVisualStyleBackColor = true;
            // 
            // createAccountPassword
            // 
            this.createAccountPassword.Location = new System.Drawing.Point(9, 71);
            this.createAccountPassword.Name = "createAccountPassword";
            this.createAccountPassword.PasswordChar = '•';
            this.createAccountPassword.Size = new System.Drawing.Size(299, 20);
            this.createAccountPassword.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Пароль:";
            // 
            // createAcoountUsername
            // 
            this.createAcoountUsername.Location = new System.Drawing.Point(9, 32);
            this.createAcoountUsername.Name = "createAcoountUsername";
            this.createAcoountUsername.Size = new System.Drawing.Size(299, 20);
            this.createAcoountUsername.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Имя пользователя:";
            // 
            // allowNewConnections
            // 
            this.allowNewConnections.AutoSize = true;
            this.allowNewConnections.Checked = true;
            this.allowNewConnections.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowNewConnections.Location = new System.Drawing.Point(552, 443);
            this.allowNewConnections.Name = "allowNewConnections";
            this.allowNewConnections.Size = new System.Drawing.Size(187, 17);
            this.allowNewConnections.TabIndex = 12;
            this.allowNewConnections.Text = "Разрешать новые подключения";
            this.allowNewConnections.UseVisualStyleBackColor = true;
            this.allowNewConnections.Visible = false;
            this.allowNewConnections.CheckedChanged += new System.EventHandler(this.allowNewConnections_CheckedChanged);
            // 
            // chatEnabled
            // 
            this.chatEnabled.AutoSize = true;
            this.chatEnabled.Checked = true;
            this.chatEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chatEnabled.Location = new System.Drawing.Point(12, 448);
            this.chatEnabled.Name = "chatEnabled";
            this.chatEnabled.Size = new System.Drawing.Size(91, 17);
            this.chatEnabled.TabIndex = 13;
            this.chatEnabled.Text = "Чат включен";
            this.chatEnabled.UseVisualStyleBackColor = true;
            this.chatEnabled.CheckedChanged += new System.EventHandler(this.chatEnabled_CheckedChanged);
            // 
            // pauseDrawing
            // 
            this.pauseDrawing.AutoSize = true;
            this.pauseDrawing.Location = new System.Drawing.Point(12, 471);
            this.pauseDrawing.Name = "pauseDrawing";
            this.pauseDrawing.Size = new System.Drawing.Size(161, 17);
            this.pauseDrawing.TabIndex = 14;
            this.pauseDrawing.Text = "Приостановить рисование";
            this.pauseDrawing.UseVisualStyleBackColor = true;
            this.pauseDrawing.CheckedChanged += new System.EventHandler(this.pauseDrawing_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Введите сообщение сервера:";
            // 
            // serverMessage
            // 
            this.serverMessage.Location = new System.Drawing.Point(12, 418);
            this.serverMessage.Name = "serverMessage";
            this.serverMessage.Size = new System.Drawing.Size(711, 20);
            this.serverMessage.TabIndex = 16;
            // 
            // sendServerMessage
            // 
            this.sendServerMessage.Location = new System.Drawing.Point(729, 417);
            this.sendServerMessage.Name = "sendServerMessage";
            this.sendServerMessage.Size = new System.Drawing.Size(23, 20);
            this.sendServerMessage.TabIndex = 17;
            this.sendServerMessage.Text = ">";
            this.sendServerMessage.UseVisualStyleBackColor = true;
            // 
            // loggingBehaviour
            // 
            this.loggingBehaviour.Tick += new System.EventHandler(this.loggingBehaviour_Tick);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 544);
            this.Controls.Add(this.sendServerMessage);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.serverMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pauseDrawing);
            this.Controls.Add(this.chatEnabled);
            this.Controls.Add(this.allowNewConnections);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.onlineUserList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullUserList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerForm";
            this.Text = "Paint Together DotNET - Режим сервера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverLog;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button shutdownServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearLogBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fullUserList;
        private System.Windows.Forms.ListBox onlineUserList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serverShutdownReason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox administratingUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button banUserIPBtn;
        private System.Windows.Forms.Button banUserBtn;
        private System.Windows.Forms.Button disconnectUserBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.TextBox administratingNewPassword;
        private System.Windows.Forms.Button applyAdministratingChanges;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button viewBanInfo;
        private System.Windows.Forms.Button unbanUser;
        private System.Windows.Forms.TextBox unbanField;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteUserAccountBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox allowNewConnections;
        private System.Windows.Forms.CheckBox chatEnabled;
        private System.Windows.Forms.CheckBox pauseDrawing;
        private System.Windows.Forms.Button clearCreateAccountForm;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.TextBox createAccountPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox createAcoountUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serverMessage;
        private System.Windows.Forms.Button sendServerMessage;
        private System.Windows.Forms.Timer loggingBehaviour;
        private System.Windows.Forms.Button kickAll;
    }
}