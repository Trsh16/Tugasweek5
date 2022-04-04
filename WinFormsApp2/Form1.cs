namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_proses_Click(object sender, EventArgs e)
        {
            if (comboBox_mode.SelectedItem == null)
            {
                MessageBox.Show("Mode belum dipilih");
            }
            if (comboBox_mode.SelectedIndex == 0)
            {
                listBox1.Items.Add(textBox_Data.Text);
                textBox_Data.Text = "";
                textBox_Data.Focus();
            }
            else
            {
                listBox1.SelectedItems.Remove(textBox_Data.Text);
            }
        }

        private void textBox_Data_TextChanged(object sender, EventArgs e)
        {
            listBox1.Text = textBox_Data.Text;
        }

        private void comboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_mode.Items.Add("Add");
            comboBox_mode.Items.Add("Replace");
        }

        private void checkBox_block_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_block.Checked)
            {
                button1 = null;
                button2 = null;
                button3 = null;
                button4 = null;
                button5 = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                    listBox1.Items.Remove(listBox1.Items[i]);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
            int i = 0;
            i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.Text);
            int i = 0;
            i = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (listBox2.Items.Count != 0)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            listBox1.Items.RemoveAt(i);
        }
    }
}