namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc bạn muốn đóng ứng dụng?", "Thông báo!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (dl == DialogResult.No)
                e.Cancel = true; // Dòng này sẽ chặn không cho Form đóng lại nếu bấm No
        }
    }
}
