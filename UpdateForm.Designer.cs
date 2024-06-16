namespace PaintTogetherNET
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.latestVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateList = new System.Windows.Forms.ListBox();
            this.goDownload = new System.Windows.Forms.Button();
            this.remindLater = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PaintTogetherNET.Properties.Resources.update;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Доступно обновление";
            // 
            // latestVersion
            // 
            this.latestVersion.AutoSize = true;
            this.latestVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latestVersion.Location = new System.Drawing.Point(117, 66);
            this.latestVersion.Name = "latestVersion";
            this.latestVersion.Size = new System.Drawing.Size(60, 24);
            this.latestVersion.TabIndex = 2;
            this.latestVersion.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите вариант поставки обновления из списка ниже:";
            // 
            // updateList
            // 
            this.updateList.FormattingEnabled = true;
            this.updateList.Location = new System.Drawing.Point(12, 127);
            this.updateList.Name = "updateList";
            this.updateList.Size = new System.Drawing.Size(315, 121);
            this.updateList.TabIndex = 4;
            this.updateList.SelectedIndexChanged += new System.EventHandler(this.updateList_SelectedIndexChanged);
            // 
            // goDownload
            // 
            this.goDownload.Enabled = false;
            this.goDownload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goDownload.Location = new System.Drawing.Point(333, 127);
            this.goDownload.Name = "goDownload";
            this.goDownload.Size = new System.Drawing.Size(279, 57);
            this.goDownload.TabIndex = 5;
            this.goDownload.Text = "Загрузить файл";
            this.goDownload.UseVisualStyleBackColor = true;
            this.goDownload.Click += new System.EventHandler(this.goDownload_Click);
            // 
            // remindLater
            // 
            this.remindLater.Location = new System.Drawing.Point(333, 190);
            this.remindLater.Name = "remindLater";
            this.remindLater.Size = new System.Drawing.Size(279, 57);
            this.remindLater.TabIndex = 6;
            this.remindLater.Text = "Напомнить позже";
            this.remindLater.UseVisualStyleBackColor = true;
            this.remindLater.Click += new System.EventHandler(this.remindLater_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 259);
            this.Controls.Add(this.remindLater);
            this.Controls.Add(this.goDownload);
            this.Controls.Add(this.updateList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.latestVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateForm";
            this.Text = "Найдено обновление";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label latestVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox updateList;
        private System.Windows.Forms.Button goDownload;
        private System.Windows.Forms.Button remindLater;
    }
}