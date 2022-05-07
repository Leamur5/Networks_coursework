
namespace Mail_kursovaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SendNewLetterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReTextbox = new System.Windows.Forms.TextBox();
            this.LetterTextBox = new System.Windows.Forms.RichTextBox();
            this.ReceiverComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.AuthConnectButton = new System.Windows.Forms.Button();
            this.AuthDisconnectButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входящиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходящиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПортовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.порт1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.порт2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenPortsButton = new System.Windows.Forms.Button();
            this.ClosePortsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inboxTableAdapter1 = new Mail_kursovaya.CourseDBTableAdapters.inboxTableAdapter();
            this.outboxTableAdapter1 = new Mail_kursovaya.CourseDBTableAdapters.outboxTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SendNewLetterButton
            // 
            this.SendNewLetterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendNewLetterButton.Location = new System.Drawing.Point(390, 109);
            this.SendNewLetterButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SendNewLetterButton.Name = "SendNewLetterButton";
            this.SendNewLetterButton.Size = new System.Drawing.Size(159, 100);
            this.SendNewLetterButton.TabIndex = 0;
            this.SendNewLetterButton.Text = "Отправить";
            this.SendNewLetterButton.UseVisualStyleBackColor = true;
            this.SendNewLetterButton.Click += new System.EventHandler(this.SendNewLetterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новое сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тема:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кому:";
            // 
            // ReTextbox
            // 
            this.ReTextbox.Location = new System.Drawing.Point(98, 114);
            this.ReTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ReTextbox.Name = "ReTextbox";
            this.ReTextbox.Size = new System.Drawing.Size(258, 26);
            this.ReTextbox.TabIndex = 4;
            // 
            // LetterTextBox
            // 
            this.LetterTextBox.Location = new System.Drawing.Point(20, 229);
            this.LetterTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LetterTextBox.Name = "LetterTextBox";
            this.LetterTextBox.Size = new System.Drawing.Size(529, 378);
            this.LetterTextBox.TabIndex = 5;
            this.LetterTextBox.Text = "";
            // 
            // ReceiverComboBox
            // 
            this.ReceiverComboBox.FormattingEnabled = true;
            this.ReceiverComboBox.Location = new System.Drawing.Point(98, 166);
            this.ReceiverComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ReceiverComboBox.Name = "ReceiverComboBox";
            this.ReceiverComboBox.Size = new System.Drawing.Size(258, 28);
            this.ReceiverComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1090, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Авторизация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1018, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Логин:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(1096, 46);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(212, 26);
            this.LoginTextBox.TabIndex = 9;
            // 
            // AuthConnectButton
            // 
            this.AuthConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthConnectButton.Location = new System.Drawing.Point(1083, 88);
            this.AuthConnectButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AuthConnectButton.Name = "AuthConnectButton";
            this.AuthConnectButton.Size = new System.Drawing.Size(104, 54);
            this.AuthConnectButton.TabIndex = 10;
            this.AuthConnectButton.Text = "Войти";
            this.AuthConnectButton.UseVisualStyleBackColor = true;
            this.AuthConnectButton.Click += new System.EventHandler(this.AuthConnectButton_Click);
            // 
            // AuthDisconnectButton
            // 
            this.AuthDisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthDisconnectButton.Location = new System.Drawing.Point(1208, 89);
            this.AuthDisconnectButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AuthDisconnectButton.Name = "AuthDisconnectButton";
            this.AuthDisconnectButton.Size = new System.Drawing.Size(102, 52);
            this.AuthDisconnectButton.TabIndex = 11;
            this.AuthDisconnectButton.Text = "Выйти";
            this.AuthDisconnectButton.UseVisualStyleBackColor = true;
            this.AuthDisconnectButton.Click += new System.EventHandler(this.AuthDisconnectButton_click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(741, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "Статус абонентов:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сообщенияToolStripMenuItem,
            this.настройкаПортовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1352, 33);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // сообщенияToolStripMenuItem
            // 
            this.сообщенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.входящиеToolStripMenuItem,
            this.исходящиеToolStripMenuItem});
            this.сообщенияToolStripMenuItem.Name = "сообщенияToolStripMenuItem";
            this.сообщенияToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.сообщенияToolStripMenuItem.Text = "Сообщения";
            // 
            // входящиеToolStripMenuItem
            // 
            this.входящиеToolStripMenuItem.Name = "входящиеToolStripMenuItem";
            this.входящиеToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.входящиеToolStripMenuItem.Text = "Входящие";
            this.входящиеToolStripMenuItem.Click += new System.EventHandler(this.входящиеToolStripMenuItem_Click);
            // 
            // исходящиеToolStripMenuItem
            // 
            this.исходящиеToolStripMenuItem.Name = "исходящиеToolStripMenuItem";
            this.исходящиеToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.исходящиеToolStripMenuItem.Text = "Исходящие";
            this.исходящиеToolStripMenuItem.Click += new System.EventHandler(this.исходящиеToolStripMenuItem_Click);
            // 
            // настройкаПортовToolStripMenuItem
            // 
            this.настройкаПортовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скоростьToolStripMenuItem,
            this.порт1ToolStripMenuItem,
            this.порт2ToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.настройкаПортовToolStripMenuItem.Name = "настройкаПортовToolStripMenuItem";
            this.настройкаПортовToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
            this.настройкаПортовToolStripMenuItem.Text = "Настройка портов";
            // 
            // скоростьToolStripMenuItem
            // 
            this.скоростьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.скоростьToolStripMenuItem.Name = "скоростьToolStripMenuItem";
            this.скоростьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.скоростьToolStripMenuItem.Text = "Скорость";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox3.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox3_SelectedIndexChanged);
            // 
            // порт1ToolStripMenuItem
            // 
            this.порт1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.порт1ToolStripMenuItem.Name = "порт1ToolStripMenuItem";
            this.порт1ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.порт1ToolStripMenuItem.Text = "Порт 1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // порт2ToolStripMenuItem
            // 
            this.порт2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.порт2ToolStripMenuItem.Name = "порт2ToolStripMenuItem";
            this.порт2ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.порт2ToolStripMenuItem.Text = "Порт 2";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1194, 702);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(741, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 38);
            this.label10.TabIndex = 23;
            this.label10.Text = "Уведомления:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(730, 611);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 176);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(104, 686);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 38);
            this.label6.TabIndex = 25;
            this.label6.Text = "Управление портами:";
            // 
            // OpenPortsButton
            // 
            this.OpenPortsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPortsButton.Location = new System.Drawing.Point(129, 738);
            this.OpenPortsButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OpenPortsButton.Name = "OpenPortsButton";
            this.OpenPortsButton.Size = new System.Drawing.Size(129, 54);
            this.OpenPortsButton.TabIndex = 26;
            this.OpenPortsButton.Text = "Открыть";
            this.OpenPortsButton.UseVisualStyleBackColor = true;
            this.OpenPortsButton.Click += new System.EventHandler(this.OpenPortsButton_Click);
            // 
            // ClosePortsButton
            // 
            this.ClosePortsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClosePortsButton.Location = new System.Drawing.Point(280, 738);
            this.ClosePortsButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ClosePortsButton.Name = "ClosePortsButton";
            this.ClosePortsButton.Size = new System.Drawing.Size(128, 54);
            this.ClosePortsButton.TabIndex = 27;
            this.ClosePortsButton.Text = "Закрыть";
            this.ClosePortsButton.UseVisualStyleBackColor = true;
            this.ClosePortsButton.Click += new System.EventHandler(this.ClosePortsButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 287);
            this.textBox1.TabIndex = 28;
            // 
            // inboxTableAdapter1
            // 
            this.inboxTableAdapter1.ClearBeforeFill = true;
            // 
            // outboxTableAdapter1
            // 
            this.outboxTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 865);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClosePortsButton);
            this.Controls.Add(this.OpenPortsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AuthDisconnectButton);
            this.Controls.Add(this.AuthConnectButton);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReceiverComboBox);
            this.Controls.Add(this.LetterTextBox);
            this.Controls.Add(this.ReTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendNewLetterButton);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "IU5 Mailru";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendNewLetterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReTextbox;
        private System.Windows.Forms.RichTextBox LetterTextBox;
        private System.Windows.Forms.ComboBox ReceiverComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button AuthConnectButton;
        private System.Windows.Forms.Button AuthDisconnectButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сообщенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входящиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходящиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПортовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem порт2ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenPortsButton;
        private System.Windows.Forms.Button ClosePortsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem порт1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem скоростьToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private CourseDBTableAdapters.inboxTableAdapter inboxTableAdapter1;
        private CourseDBTableAdapters.outboxTableAdapter outboxTableAdapter1;
    }
}

