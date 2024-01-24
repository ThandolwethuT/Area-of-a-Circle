namespace Area_of_a_Circle
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            double r;
            const double pi = 3.14;

            if (double.TryParse(textBox1.Text, out r))
            {
                a = pi * Math.Pow(r, 2);
                textBox2.Text = a.ToString();
            }
            else
            {
                MessageBox.Show("Enter valid numeric value.");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
