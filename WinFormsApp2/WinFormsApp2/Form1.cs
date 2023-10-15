using System;

namespace WinFormsApp2
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
            // T?o s? ng?u nhiên t? 1 ??n 100
            int randomNumber = random.Next(1, 101);

            // Hi?n th? s? ng?u nhiên trong Label
            label1.Text =  randomNumber.ToString();
        }
    }
}