
namespace Mail_kursovaya
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отправитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Получатель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тема = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время_получения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Письмо = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDB = new Mail_kursovaya.CourseDB();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ResendButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LetterTextBox = new System.Windows.Forms.RichTextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outboxTableAdapter1 = new Mail_kursovaya.CourseDBTableAdapters.outboxTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.FormStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.Отправитель,
            this.Получатель,
            this.Тема,
            this.Статус,
            this.Время_получения,
            this.Письмо,
            this.idDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.recepientDataGridViewTextBoxColumn,
            this.reDataGridViewTextBoxColumn,
            this.msgDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.datesentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.outboxBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 282);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Номер
            // 
            this.Номер.DataPropertyName = "Id";
            this.Номер.HeaderText = "Номер";
            this.Номер.MinimumWidth = 6;
            this.Номер.Name = "Номер";
            this.Номер.ReadOnly = true;
            this.Номер.Width = 80;
            // 
            // Отправитель
            // 
            this.Отправитель.DataPropertyName = "sender";
            this.Отправитель.HeaderText = "Отправитель";
            this.Отправитель.MinimumWidth = 6;
            this.Отправитель.Name = "Отправитель";
            this.Отправитель.ReadOnly = true;
            this.Отправитель.Width = 125;
            // 
            // Получатель
            // 
            this.Получатель.DataPropertyName = "recepient";
            this.Получатель.HeaderText = "Получатель";
            this.Получатель.MinimumWidth = 6;
            this.Получатель.Name = "Получатель";
            this.Получатель.ReadOnly = true;
            this.Получатель.Width = 125;
            // 
            // Тема
            // 
            this.Тема.DataPropertyName = "re";
            this.Тема.HeaderText = "Тема";
            this.Тема.MinimumWidth = 6;
            this.Тема.Name = "Тема";
            this.Тема.ReadOnly = true;
            this.Тема.Width = 125;
            // 
            // Статус
            // 
            this.Статус.DataPropertyName = "status";
            this.Статус.HeaderText = "Статус";
            this.Статус.MinimumWidth = 6;
            this.Статус.Name = "Статус";
            this.Статус.ReadOnly = true;
            this.Статус.Width = 125;
            // 
            // Время_получения
            // 
            this.Время_получения.DataPropertyName = "date_sent";
            this.Время_получения.HeaderText = "Время отправки";
            this.Время_получения.MinimumWidth = 6;
            this.Время_получения.Name = "Время_получения";
            this.Время_получения.ReadOnly = true;
            this.Время_получения.Width = 125;
            // 
            // Письмо
            // 
            this.Письмо.DataPropertyName = "msg";
            this.Письмо.HeaderText = "Письмо";
            this.Письмо.MinimumWidth = 6;
            this.Письмо.Name = "Письмо";
            this.Письмо.ReadOnly = true;
            this.Письмо.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "sender";
            this.senderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.ReadOnly = true;
            this.senderDataGridViewTextBoxColumn.Width = 150;
            // 
            // recepientDataGridViewTextBoxColumn
            // 
            this.recepientDataGridViewTextBoxColumn.DataPropertyName = "recepient";
            this.recepientDataGridViewTextBoxColumn.HeaderText = "recepient";
            this.recepientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recepientDataGridViewTextBoxColumn.Name = "recepientDataGridViewTextBoxColumn";
            this.recepientDataGridViewTextBoxColumn.ReadOnly = true;
            this.recepientDataGridViewTextBoxColumn.Width = 150;
            // 
            // reDataGridViewTextBoxColumn
            // 
            this.reDataGridViewTextBoxColumn.DataPropertyName = "re";
            this.reDataGridViewTextBoxColumn.HeaderText = "re";
            this.reDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reDataGridViewTextBoxColumn.Name = "reDataGridViewTextBoxColumn";
            this.reDataGridViewTextBoxColumn.ReadOnly = true;
            this.reDataGridViewTextBoxColumn.Width = 150;
            // 
            // msgDataGridViewTextBoxColumn
            // 
            this.msgDataGridViewTextBoxColumn.DataPropertyName = "msg";
            this.msgDataGridViewTextBoxColumn.HeaderText = "msg";
            this.msgDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.msgDataGridViewTextBoxColumn.Name = "msgDataGridViewTextBoxColumn";
            this.msgDataGridViewTextBoxColumn.ReadOnly = true;
            this.msgDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // datesentDataGridViewTextBoxColumn
            // 
            this.datesentDataGridViewTextBoxColumn.DataPropertyName = "date_sent";
            this.datesentDataGridViewTextBoxColumn.HeaderText = "date_sent";
            this.datesentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datesentDataGridViewTextBoxColumn.Name = "datesentDataGridViewTextBoxColumn";
            this.datesentDataGridViewTextBoxColumn.ReadOnly = true;
            this.datesentDataGridViewTextBoxColumn.Width = 150;
            // 
            // outboxBindingSource
            // 
            this.outboxBindingSource.DataMember = "outbox";
            this.outboxBindingSource.DataSource = this.courseDB;
            // 
            // courseDB
            // 
            this.courseDB.DataSetName = "CourseDB";
            this.courseDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(526, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список исходящих";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1262, 545);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // ResendButton
            // 
            this.ResendButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResendButton.Location = new System.Drawing.Point(1248, 526);
            this.ResendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResendButton.Name = "ResendButton";
            this.ResendButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResendButton.Size = new System.Drawing.Size(187, 78);
            this.ResendButton.TabIndex = 33;
            this.ResendButton.Text = "Переслать";
            this.ResendButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResendButton.UseVisualStyleBackColor = true;
            this.ResendButton.Click += new System.EventHandler(this.ResendButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(78, 639);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Тело письма:";
            // 
            // LetterTextBox
            // 
            this.LetterTextBox.Location = new System.Drawing.Point(57, 696);
            this.LetterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LetterTextBox.Name = "LetterTextBox";
            this.LetterTextBox.Size = new System.Drawing.Size(1320, 316);
            this.LetterTextBox.TabIndex = 29;
            this.LetterTextBox.Text = "";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(932, 518);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(257, 26);
            this.StatusTextBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(813, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Статус:";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(932, 578);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(257, 26);
            this.TimeTextBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(702, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Время получения:";
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(359, 516);
            this.SenderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(257, 26);
            this.SenderTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(179, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Отправитель:";
            // 
            // ReTextBox
            // 
            this.ReTextBox.Location = new System.Drawing.Point(359, 576);
            this.ReTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReTextBox.Name = "ReTextBox";
            this.ReTextBox.Size = new System.Drawing.Size(257, 26);
            this.ReTextBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(263, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Тема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(526, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "Отправленное сообщение";
            // 
            // outboxTableAdapter1
            // 
            this.outboxTableAdapter1.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1030, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Статус формы:";
            // 
            // FormStatusLabel
            // 
            this.FormStatusLabel.AutoSize = true;
            this.FormStatusLabel.Location = new System.Drawing.Point(1161, 47);
            this.FormStatusLabel.Name = "FormStatusLabel";
            this.FormStatusLabel.Size = new System.Drawing.Size(132, 20);
            this.FormStatusLabel.TabIndex = 36;
            this.FormStatusLabel.Text = "FormStatusLabel";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1478, 1039);
            this.Controls.Add(this.FormStatusLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ResendButton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ResendButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox LetterTextBox;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CourseDBTableAdapters.outboxTableAdapter outboxTableAdapter1;
        private CourseDB courseDB;
        private System.Windows.Forms.BindingSource outboxBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FormStatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тема;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_получения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Письмо;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesentDataGridViewTextBoxColumn;
    }
}