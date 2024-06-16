namespace PaintTogetherNET
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ClientModeBtn = new System.Windows.Forms.Button();
            this.ServerModeBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DebugModeBtn = new System.Windows.Forms.Button();
            this.closeBehavior = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paint Together";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientModeBtn
            // 
            this.ClientModeBtn.Location = new System.Drawing.Point(19, 61);
            this.ClientModeBtn.Name = "ClientModeBtn";
            this.ClientModeBtn.Size = new System.Drawing.Size(193, 47);
            this.ClientModeBtn.TabIndex = 1;
            this.ClientModeBtn.Text = "Режим клиента";
            this.ClientModeBtn.UseVisualStyleBackColor = true;
            this.ClientModeBtn.Click += new System.EventHandler(this.ClientModeBtn_Click);
            // 
            // ServerModeBtn
            // 
            this.ServerModeBtn.Location = new System.Drawing.Point(19, 114);
            this.ServerModeBtn.Name = "ServerModeBtn";
            this.ServerModeBtn.Size = new System.Drawing.Size(193, 47);
            this.ServerModeBtn.TabIndex = 2;
            this.ServerModeBtn.Text = "Режим сервера";
            this.ServerModeBtn.UseVisualStyleBackColor = true;
            this.ServerModeBtn.Click += new System.EventHandler(this.ServerModeBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Location = new System.Drawing.Point(19, 167);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(193, 47);
            this.AboutBtn.TabIndex = 3;
            this.AboutBtn.Text = "О программе";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(19, 273);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(193, 47);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // DebugModeBtn
            // 
            this.DebugModeBtn.Enabled = false;
            this.DebugModeBtn.Location = new System.Drawing.Point(19, 220);
            this.DebugModeBtn.Name = "DebugModeBtn";
            this.DebugModeBtn.Size = new System.Drawing.Size(193, 47);
            this.DebugModeBtn.TabIndex = 6;
            this.DebugModeBtn.Text = "Для тестировщиков";
            this.DebugModeBtn.UseVisualStyleBackColor = true;
            this.DebugModeBtn.Click += new System.EventHandler(this.DebugModeBtn_Click);
            // 
            // closeBehavior
            // 
            this.closeBehavior.Enabled = true;
            this.closeBehavior.Tick += new System.EventHandler(this.closeBehavior_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 329);
            this.Controls.Add(this.DebugModeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.ServerModeBtn);
            this.Controls.Add(this.ClientModeBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Paint Together DotNET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientModeBtn;
        private System.Windows.Forms.Button ServerModeBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DebugModeBtn;
        private System.Windows.Forms.Timer closeBehavior;
    }
}

