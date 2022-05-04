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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AuthConnectButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public Form1 form1;

        public bool UpdateThread_to_close = false;
        public Form2(Form1 form)
        {

            UpdateThread_to_close = false;
            this.form1 = form;
            InitializeComponent();
            Thread LookForInboxUpdatesthr = new Thread(LookForInboxUpdates);
            LookForInboxUpdatesthr.IsBackground = true;
            LookForInboxUpdatesthr.Start();

        }

        public void Show_Inbox()
        {

            //using (CourseDBContainer db = new CourseDBContainer())
            //{
                dataGridView1.DataSource = inboxTableAdapter1.GetData().ToList();
            //}
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[5].Width = 90;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Принято")
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;

                }
                if (row.Cells[5].Value.ToString() == "Прочитано")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCyan;
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseDB.inbox". При необходимости она может быть перемещена или удалена.
            this.inboxTableAdapter1.Fill(this.courseDB.inbox);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Show_Inbox();
        }

        private delegate void SetTextDeleg(string text);
        public void setlabel4state(string text)
        {
            label4.Text = text;
        }
        private delegate void UpdateDataGridDeleg(List<CourseDB.inboxRow> list);
        public void UpdateDataGrid1(List<CourseDB.inboxRow> list)
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
                    row.DefaultCellStyle.BackColor = Color.LightCyan;
                }
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        public void LookForInboxUpdates()
        {
            while (true)
            {
                form1.Inbox_update_mutex.WaitOne();
                if (form1.Inbox_update_needed)
                {
                    form1.Inbox_update_needed = false;
                    form1.Inbox_update_mutex.ReleaseMutex();


                    BeginInvoke(new SetTextDeleg(setlabel4state), new object[] { "обновляется" });
                    //using (CourseDBContainer db = new CourseDBContainer())
                    {
                        BeginInvoke(new UpdateDataGridDeleg(UpdateDataGrid1), new object[] { inboxTableAdapter1.GetData().ToList() });
                    }
                }
                else
                {
                    form1.Inbox_update_mutex.ReleaseMutex();
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

                try { LetterTextBox.Text = row.Cells[7].Value.ToString(); }
                catch (Exception ex) { LetterTextBox.Text = ""; }
                try
                { TimeTextBox.Text = row.Cells[5].Value.ToString(); }
                catch (Exception ex) { TimeTextBox.Text = ""; }

                //Попытка отправить уведомление о прочтении
                bool foreign_id_exists = false;
                string foreign_id_string = "";
                string sender_string = "";
                string status_string = "";
                try
                {
                    foreign_id_string = row.Cells[6].Value.ToString();
                    sender_string = row.Cells[1].Value.ToString();
                    status_string = row.Cells[5].Value.ToString();
                    foreign_id_exists = true;
                }
                catch (Exception ex)
                {
                    foreign_id_exists = false;
                }
                if (foreign_id_exists)
                {
                    if (form1.AuthData["Port1"] != null && form1.AuthData["Port2"] != null && form1.AuthData["local"] != null)
                    {
                        if (status_string != "Прочитано")
                        {
                            int len = foreign_id_string.Length;
                            // Здесь ожидаем получения мьютекса на создание заданий
                            // После получения, используя методы Form1 создается кадр об открытии письма
                            // Необходимо получить значение "Port1/2" по ключу "sender",
                            // а также номер машины, за которой сидит этот sender
                            var Receiver_Port = form1.AuthData.FirstOrDefault(x => x.Value == sender_string).Key;
                            //either "Port1" or "Port2"
                            string Port = Receiver_Port.ToString();

                            //Конвертирование из utf-8 в win1251 уже предусмотрено в функции
                            byte[] frame = form1.CreateNewFrame(Form1.FrameType.OPENLETTER, "0", len.ToString(), "0", foreign_id_string, false);

                            Form1.One_Task openletterframe = new Form1.One_Task();

                            form1.TaskToSend_mutex.WaitOne();
                            form1.TasksToSend.Add(new Form1.One_Task(Receiver_Port, frame));
                            form1.TaskToSend_mutex.ReleaseMutex();

                            //using (CourseDBContainer db = new CourseDBContainer())
                            {
                                var foreign_id_num = long.Parse(foreign_id_string);
                                var result = inboxTableAdapter1.GetData().SingleOrDefault(x => x.foreign_id == foreign_id_num.ToString());
                                if (result != null)
                                {
                                    result.status = "Прочитано";
                                    //db.SaveChanges();
                                    form1.Inbox_update_mutex.WaitOne();
                                    form1.Inbox_update_needed = true;
                                    form1.Inbox_update_mutex.ReleaseMutex();
                                }
                            }
                        }
                        else
                        {

                        }
                    }
                }

            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateThread_to_close = true;
            Thread.Sleep(2500);
        }
    }
}

