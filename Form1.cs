namespace ManageClients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] userName = { "Xeyyam", "Ariz", "Samire", "Nuran" };
        int[] Pin = { 1122, 1234, 4321, 0000 };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == userName[0] && textBox2.Text == Pin[0].ToString()
                || textBox1.Text == userName[1] && textBox2.Text == Pin[1].ToString()
                || textBox1.Text == userName[2] && textBox2.Text == Pin[2].ToString()
                || textBox1.Text == userName[3] && textBox2.Text == Pin[3].ToString()
                )
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                label4.Visible = true;
            }
        }

        public void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

    }

}