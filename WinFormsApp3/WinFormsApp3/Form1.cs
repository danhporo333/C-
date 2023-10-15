namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            int result = number1 + number2;
            button1.Text = $"{number1} + {number2} = {result}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            int result = number1 - number2;
            button1.Text = $"{number1} - {number2} = {result}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            int result = number1 * number2;
            button1.Text = $"{number1} * {number2} = {result}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            int result = number1 / number2;
            button1.Text = $"{number1} / {number2} = {result}";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            button1.Text = $"{number1} + {number2} = {result}";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}