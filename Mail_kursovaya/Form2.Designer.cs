
namespace Mail_kursovaya
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отправитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Получатель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тема = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время_получения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Письмо = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ReTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LetterTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AuthConnectButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(654, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список входящих";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.Отправитель,
            this.Получатель,
            this.Тема,
            this.Статус,
            this.Время_получения,
            this.Письмо});
            this.dataGridView1.Location = new System.Drawing.Point(105, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 282);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Номер
            // 
            this.Номер.HeaderText = "Номер";
            this.Номер.MinimumWidth = 6;
            this.Номер.Name = "Номер";
            this.Номер.ReadOnly = true;
            this.Номер.Width = 80;
            // 
            // Отправитель
            // 
            this.Отправитель.HeaderText = "Отправитель";
            this.Отправитель.MinimumWidth = 6;
            this.Отправитель.Name = "Отправитель";
            this.Отправитель.ReadOnly = true;
            this.Отправитель.Width = 125;
            // 
            // Получатель
            // 
            this.Получатель.HeaderText = "Получатель";
            this.Получатель.MinimumWidth = 6;
            this.Получатель.Name = "Получатель";
            this.Получатель.ReadOnly = true;
            this.Получатель.Width = 125;
            // 
            // Тема
            // 
            this.Тема.HeaderText = "Тема";
            this.Тема.MinimumWidth = 6;
            this.Тема.Name = "Тема";
            this.Тема.ReadOnly = true;
            this.Тема.Width = 125;
            // 
            // Статус
            // 
            this.Статус.HeaderText = "Статус";
            this.Статус.MinimumWidth = 6;
            this.Статус.Name = "Статус";
            this.Статус.ReadOnly = true;
            this.Статус.Width = 125;
            // 
            // Время_получения
            // 
            this.Время_получения.HeaderText = "Время получения";
            this.Время_получения.MinimumWidth = 6;
            this.Время_получения.Name = "Время_получения";
            this.Время_получения.ReadOnly = true;
            this.Время_получения.Width = 125;
            // 
            // Письмо
            // 
            this.Письмо.HeaderText = "Письмо";
            this.Письмо.MinimumWidth = 6;
            this.Письмо.Name = "Письмо";
            this.Письмо.ReadOnly = true;
            this.Письмо.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(623, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Полученное сообщение";
            // 
            // ReTextBox
            // 
            this.ReTextBox.Location = new System.Drawing.Point(406, 509);
            this.ReTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReTextBox.Name = "ReTextBox";
            this.ReTextBox.Size = new System.Drawing.Size(257, 26);
            this.ReTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(310, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тема:";
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(406, 449);
            this.SenderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(257, 26);
            this.SenderTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(226, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отправитель:";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(979, 450);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(257, 26);
            this.StatusTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(861, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Статус:";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(979, 510);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(257, 26);
            this.TimeTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(749, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Время получения:";
            // 
            // LetterTextBox
            // 
            this.LetterTextBox.Location = new System.Drawing.Point(105, 629);
            this.LetterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LetterTextBox.Name = "LetterTextBox";
            this.LetterTextBox.Size = new System.Drawing.Size(1320, 316);
            this.LetterTextBox.TabIndex = 13;
            this.LetterTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(125, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Тело письма:";
            // 
            // AuthConnectButton
            // 
            this.AuthConnectButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AuthConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthConnectButton.Location = new System.Drawing.Point(1292, 424);
            this.AuthConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthConnectButton.Name = "AuthConnectButton";
            this.AuthConnectButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthConnectButton.Size = new System.Drawing.Size(187, 78);
            this.AuthConnectButton.TabIndex = 15;
            this.AuthConnectButton.Text = "Ответить";
            this.AuthConnectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AuthConnectButton.UseVisualStyleBackColor = true;
            this.AuthConnectButton.Click += new System.EventHandler(this.AuthConnectButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1306, 444);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1306, 529);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1292, 510);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(187, 78);
            this.button2.TabIndex = 18;
            this.button2.Text = "Переслать";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1536, 1050);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AuthConnectButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LetterTextBox);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Входящие";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тема;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_получения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Письмо;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox LetterTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AuthConnectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}