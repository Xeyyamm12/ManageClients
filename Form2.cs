using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageClients
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Surname", typeof(string));
            dt.Columns.Add("Phone No", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text, textBox5.Text);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
