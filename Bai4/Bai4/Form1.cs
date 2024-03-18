namespace Bai4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int fromBase = 10;
                int toBase = 10;

                if (comboBox1.Text == "Hexa")
                {
                    fromBase = 16;
                }
                else if (comboBox1.Text == "Decimal")
                {
                    fromBase = 10;
                }
                else if (comboBox1.Text == "Binary")
                {
                    fromBase = 2;
                }
                if (comboBox2.Text == "Hexa")
                {
                    toBase = 16;

                }
                else if (comboBox2.Text == "Decimal")
                {
                    toBase = 10;
                }
                else if (comboBox2.Text == "Binary")
                {
                    toBase = 2;
                }
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, fromBase), toBase);
            }
            catch {
                MessageBox.Show("Error: Khong hop le");
            }
        }
    }
}