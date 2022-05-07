
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
            this.components = new System.ComponentModel.Container();
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
            this.foreign_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDB = new Mail_kursovaya.CourseDB();
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
            this.ReplyConnectButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.inboxTableAdapter1 = new Mail_kursovaya.CourseDBTableAdapters.inboxTableAdapter();
            this.FormStatusLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datereceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foreignidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDB)).BeginInit();
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
            this.foreign_id,
            this.idDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.recepientDataGridViewTextBoxColumn,
            this.reDataGridViewTextBoxColumn,
            this.msgDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.datereceivedDataGridViewTextBoxColumn,
            this.foreignidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inboxBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 282);
            this.dataGridView1.TabIndex = 3;
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
            this.Время_получения.DataPropertyName = "date_received";
            this.Время_получения.HeaderText = "Время получения";
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
            // foreign_id
            // 
            this.foreign_id.DataPropertyName = "foreign_id";
            this.foreign_id.HeaderText = "foreign_id";
            this.foreign_id.MinimumWidth = 8;
            this.foreign_id.Name = "foreign_id";
            this.foreign_id.ReadOnly = true;
            this.foreign_id.Visible = false;
            this.foreign_id.Width = 150;
            // 
            // inboxBindingSource
            // 
            this.inboxBindingSource.DataMember = "inbox";
            this.inboxBindingSource.DataSource = this.courseDBBindingSource;
            // 
            // courseDBBindingSource
            // 
            this.courseDBBindingSource.DataSource = this.courseDB;
            this.courseDBBindingSource.Position = 0;
            // 
            // courseDB
            // 
            this.courseDB.DataSetName = "CourseDB";
            this.courseDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ReplyConnectButton
            // 
            this.ReplyConnectButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReplyConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplyConnectButton.Location = new System.Drawing.Point(1292, 424);
            this.ReplyConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReplyConnectButton.Name = "ReplyConnectButton";
            this.ReplyConnectButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReplyConnectButton.Size = new System.Drawing.Size(187, 78);
            this.ReplyConnectButton.TabIndex = 15;
            this.ReplyConnectButton.Text = "Ответить";
            this.ReplyConnectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReplyConnectButton.UseVisualStyleBackColor = true;
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
            // inboxTableAdapter1
            // 
            this.inboxTableAdapter1.ClearBeforeFill = true;
            // 
            // FormStatusLabel
            // 
            this.FormStatusLabel.AutoSize = true;
            this.FormStatusLabel.Location = new System.Drawing.Point(1294, 24);
            this.FormStatusLabel.Name = "FormStatusLabel";
            this.FormStatusLabel.Size = new System.Drawing.Size(132, 20);
            this.FormStatusLabel.TabIndex = 38;
            this.FormStatusLabel.Text = "FormStatusLabel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1163, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Статус формы:";
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
            // datereceivedDataGridViewTextBoxColumn
            // 
            this.datereceivedDataGridViewTextBoxColumn.DataPropertyName = "date_received";
            this.datereceivedDataGridViewTextBoxColumn.HeaderText = "date_received";
            this.datereceivedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datereceivedDataGridViewTextBoxColumn.Name = "datereceivedDataGridViewTextBoxColumn";
            this.datereceivedDataGridViewTextBoxColumn.ReadOnly = true;
            this.datereceivedDataGridViewTextBoxColumn.Width = 150;
            // 
            // foreignidDataGridViewTextBoxColumn
            // 
            this.foreignidDataGridViewTextBoxColumn.DataPropertyName = "foreign_id";
            this.foreignidDataGridViewTextBoxColumn.HeaderText = "foreign_id";
            this.foreignidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.foreignidDataGridViewTextBoxColumn.Name = "foreignidDataGridViewTextBoxColumn";
            this.foreignidDataGridViewTextBoxColumn.ReadOnly = true;
            this.foreignidDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1536, 1050);
            this.Controls.Add(this.FormStatusLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReplyConnectButton);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button ReplyConnectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private CourseDBTableAdapters.inboxTableAdapter inboxTableAdapter1;
        private System.Windows.Forms.BindingSource courseDBBindingSource;
        private CourseDB courseDB;
        private System.Windows.Forms.BindingSource inboxBindingSource;
        private System.Windows.Forms.Label FormStatusLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отправитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Получатель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тема;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время_получения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Письмо;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreign_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreignidDataGridViewTextBoxColumn;
    }
}