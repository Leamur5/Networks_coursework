using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Data.Common;
using Newtonsoft.Json;
using System.Drawing;

namespace Mail_kursovaya
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form1 form1;

        public bool UpdateThread_to_close = false;

        public Form3(Form1 form)
        {
            UpdateThread_to_close = false;
            this.form1 = form;
            InitializeComponent();
            Thread LookForOutboxUpdatesthr = new Thread(LookForOutboxUpdates);
            LookForOutboxUpdatesthr.IsBackground = true;

            LookForOutboxUpdatesthr.Start();
        }

        public void Show_Outbox()
        {
            //using (CourseDBContainer db = new CourseDBContainer())
            {
                dataGridView1.DataSource = outboxTableAdapter1.GetData().ToList();
            }
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[0].Width = 20;
            //dataGridView1.Columns[4].Width = 50;
            //dataGridView1.Columns[2].Width = 50;
            //dataGridView1.Columns[3].Width = 80;
            //dataGridView1.Columns[5].Width = 190;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Принято")
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;

                }
                if (row.Cells[5].Value.ToString() == "Прочитано")
                {
                    row.DefaultCellStyle.BackColor = Color.Azure;
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();

        }


        private delegate void SetTextDeleg(string text);
        public void setlabel4state(string text)
        {
            FormStatusLabel.Text = text;
        }

        private delegate void UpdateDataGridDeleg(List<CourseDB.outboxRow> list);
        public void UpdateDataGrid1(List<CourseDB.outboxRow> list)
        {
            dataGridView1.DataSource = list;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Принято")
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;

                }
                if (row.Cells[5].Value.ToString() == "Прочитано")
                {
                    row.DefaultCellStyle.BackColor = Color.Azure;
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        public void LookForOutboxUpdates()
        {
            while (true)
            {
                form1.Outbox_update_mutex.WaitOne();

                if (form1.Outbox_update_needed)
                {
                    form1.Outbox_update_needed = false;
                    form1.Outbox_update_mutex.ReleaseMutex();

                    BeginInvoke(new SetTextDeleg(setlabel4state), new object[] { "обновляется" });
                    //using (CourseDBContainer db = new CourseDBContainer())
                    {
                        BeginInvoke(new UpdateDataGridDeleg(UpdateDataGrid1), new object[] { outboxTableAdapter1.GetData().ToList() });
                    }
                }
                else
                {
                    form1.Outbox_update_mutex.ReleaseMutex();
                }

                Thread.Sleep(1000);
                BeginInvoke(new SetTextDeleg(setlabel4state), new object[] { "ожидание" });

                if (UpdateThread_to_close)
                {
                    break;
                }
            }
        }

        //Обработка клика на письмо 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                //Отображение письма в текстБоксы 

                try { SenderTextBox.Text = row.Cells[1].Value.ToString(); }
                catch (Exception ex) { SenderTextBox.Text = ""; }

                try { ReTextBox.Text = row.Cells[3].Value.ToString(); }
                catch (Exception ex) { StatusTextBox.Text = ""; }

                try { StatusTextBox.Text = row.Cells[4].Value.ToString(); }
                catch (Exception ex) { TimeTextBox.Text = ""; }

                try { LetterTextBox.Text = row.Cells[6].Value.ToString(); }
                catch (Exception ex) { LetterTextBox.Text = ""; }
                try
                { TimeTextBox.Text = row.Cells[5].Value.ToString(); }
                catch (Exception ex) { TimeTextBox.Text = ""; }

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseDB.outbox". При необходимости она может быть перемещена или удалена.
            this.outboxTableAdapter1.Fill(this.courseDB.outbox);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Show_Outbox();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateThread_to_close = true;
            Thread.Sleep(2500);
        }
    }
}

