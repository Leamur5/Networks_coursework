using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void скоростьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void входящиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 inbox_folder = new Form2();
            inbox_folder.Show();
        }

        private void исходящиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 inbox_folder = new Form3();
            inbox_folder.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
