namespace PaintTogetherNET
{
    partial class ClientForm
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
            this.canvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brushSize = new System.Windows.Forms.NumericUpDown();
            this.secondaryColor = new System.Windows.Forms.Label();
            this.primaryColor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectSecondaryColor = new System.Windows.Forms.Button();
            this.selectPrimaryColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSpray = new System.Windows.Forms.RadioButton();
            this.rbBrush = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.pictureExport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chatSendBtn = new System.Windows.Forms.Button();
            this.chatText = new System.Windows.Forms.TextBox();
            this.chatLog = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chatBehaviour = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(202, 31);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(384, 384);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Холст";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.brushSize);
            this.groupBox1.Controls.Add(this.secondaryColor);
            this.groupBox1.Controls.Add(this.primaryColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectSecondaryColor);
            this.groupBox1.Controls.Add(this.selectPrimaryColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbSpray);
            this.groupBox1.Controls.Add(this.rbBrush);
            this.groupBox1.Controls.Add(this.rbPen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 432);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // brushSize
            // 
            this.brushSize.Location = new System.Drawing.Point(6, 124);
            this.brushSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.brushSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(169, 20);
            this.brushSize.TabIndex = 11;
            this.brushSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // secondaryColor
            // 
            this.secondaryColor.AutoSize = true;
            this.secondaryColor.BackColor = System.Drawing.Color.White;
            this.secondaryColor.Location = new System.Drawing.Point(91, 218);
            this.secondaryColor.Name = "secondaryColor";
            this.secondaryColor.Size = new System.Drawing.Size(62, 13);
            this.secondaryColor.TabIndex = 10;
            this.secondaryColor.Text = "Вторичный";
            // 
            // primaryColor
            // 
            this.primaryColor.AutoSize = true;
            this.primaryColor.BackColor = System.Drawing.Color.Black;
            this.primaryColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.primaryColor.Location = new System.Drawing.Point(28, 218);
            this.primaryColor.Name = "primaryColor";
            this.primaryColor.Size = new System.Drawing.Size(57, 13);
            this.primaryColor.TabIndex = 9;
            this.primaryColor.Text = "Основной";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 183);
            this.label3.TabIndex = 8;
            this.label3.Text = "Для рисования основным цветом, нажмите и удерживайте левую кнопку мыши. Чтобы рис" +
    "овать вторичным цветом, нажмите и удерживайте правую кнопку мыши";
            // 
            // selectSecondaryColor
            // 
            this.selectSecondaryColor.Location = new System.Drawing.Point(6, 179);
            this.selectSecondaryColor.Name = "selectSecondaryColor";
            this.selectSecondaryColor.Size = new System.Drawing.Size(169, 23);
            this.selectSecondaryColor.TabIndex = 7;
            this.selectSecondaryColor.Text = "Выбрать вторичный цвет";
            this.selectSecondaryColor.UseVisualStyleBackColor = true;
            this.selectSecondaryColor.Click += new System.EventHandler(this.selectSecondaryColor_Click);
            // 
            // selectPrimaryColor
            // 
            this.selectPrimaryColor.Location = new System.Drawing.Point(6, 150);
            this.selectPrimaryColor.Name = "selectPrimaryColor";
            this.selectPrimaryColor.Size = new System.Drawing.Size(169, 23);
            this.selectPrimaryColor.TabIndex = 6;
            this.selectPrimaryColor.Text = "Выбрать основной цвет";
            this.selectPrimaryColor.UseVisualStyleBackColor = true;
            this.selectPrimaryColor.Click += new System.EventHandler(this.selectPrimaryColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер кисти";
            // 
            // rbSpray
            // 
            this.rbSpray.AutoSize = true;
            this.rbSpray.Location = new System.Drawing.Point(6, 65);
            this.rbSpray.Name = "rbSpray";
            this.rbSpray.Size = new System.Drawing.Size(180, 17);
            this.rbSpray.TabIndex = 2;
            this.rbSpray.Text = "Баллончик [НЕСОВМЕСТИМО]";
            this.rbSpray.UseVisualStyleBackColor = true;
            this.rbSpray.Visible = false;
            // 
            // rbBrush
            // 
            this.rbBrush.AutoSize = true;
            this.rbBrush.Location = new System.Drawing.Point(6, 42);
            this.rbBrush.Name = "rbBrush";
            this.rbBrush.Size = new System.Drawing.Size(55, 17);
            this.rbBrush.TabIndex = 1;
            this.rbBrush.Text = "Кисть";
            this.rbBrush.UseVisualStyleBackColor = true;
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Checked = true;
            this.rbPen.Location = new System.Drawing.Point(6, 19);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(76, 17);
            this.rbPen.TabIndex = 0;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Карандаш";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // pictureExport
            // 
            this.pictureExport.Enabled = false;
            this.pictureExport.Location = new System.Drawing.Point(202, 421);
            this.pictureExport.Name = "pictureExport";
            this.pictureExport.Size = new System.Drawing.Size(384, 23);
            this.pictureExport.TabIndex = 3;
            this.pictureExport.Text = "Экспорт (Скоро)";
            this.pictureExport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chatSendBtn);
            this.groupBox2.Controls.Add(this.chatText);
            this.groupBox2.Controls.Add(this.chatLog);
            this.groupBox2.Location = new System.Drawing.Point(592, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 432);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Чат";
            // 
            // chatSendBtn
            // 
            this.chatSendBtn.Location = new System.Drawing.Point(171, 406);
            this.chatSendBtn.Name = "chatSendBtn";
            this.chatSendBtn.Size = new System.Drawing.Size(25, 23);
            this.chatSendBtn.TabIndex = 11;
            this.chatSendBtn.Text = ">";
            this.chatSendBtn.UseVisualStyleBackColor = true;
            this.chatSendBtn.Click += new System.EventHandler(this.chatSendBtn_Click);
            // 
            // chatText
            // 
            this.chatText.Location = new System.Drawing.Point(6, 408);
            this.chatText.Name = "chatText";
            this.chatText.Size = new System.Drawing.Size(166, 20);
            this.chatText.TabIndex = 1;
            // 
            // chatLog
            // 
            this.chatLog.BackColor = System.Drawing.Color.Black;
            this.chatLog.ForeColor = System.Drawing.Color.Lime;
            this.chatLog.Location = new System.Drawing.Point(6, 16);
            this.chatLog.Multiline = true;
            this.chatLog.Name = "chatLog";
            this.chatLog.ReadOnly = true;
            this.chatLog.Size = new System.Drawing.Size(190, 387);
            this.chatLog.TabIndex = 0;
            this.chatLog.Text = "Ошибка";
            // 
            // chatBehaviour
            // 
            this.chatBehaviour.Tick += new System.EventHandler(this.chatBehaviour_Tick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureExport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "Paint Together DotNET - Режим клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pictureExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSpray;
        private System.Windows.Forms.RadioButton rbBrush;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label secondaryColor;
        private System.Windows.Forms.Label primaryColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectSecondaryColor;
        private System.Windows.Forms.Button selectPrimaryColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chatLog;
        private System.Windows.Forms.Button chatSendBtn;
        private System.Windows.Forms.TextBox chatText;
        private System.Windows.Forms.NumericUpDown brushSize;
        private System.Windows.Forms.Timer chatBehaviour;
    }
}