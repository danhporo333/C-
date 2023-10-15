using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace WinFormsApp1_1
{
    public partial class Form2 : Form
    {
        private Random random = new Random();
        private object lblRandomNumber;

        public Form2()
        {

            InitializeComponent();
            this.BackColor = System.Drawing.Color.Red;
            this.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        /*
        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            Random rand = new Random();
            //this.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256));
            //MessageBox.Show("hello");

        }
        
        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                // Nếu nhấp chuột trái, tăng giá trị lên 1
                int counter = int.Parse(Text.ToString());
                counter++;
                //Form2.Text = counter.ToString();
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Nếu nhấp chuột phải, giảm giá trị đi 1
                int counter = int.Parse(Text.ToString());
                counter--;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        */
        private void btnGenerateRandom_Click(object sender, EventArgs e)
        {
            // Tạo số ngẫu nhiên từ 1 đến 100
            int randomNumber = random.Next(1, 101);

            // Hiển thị số ngẫu nhiên trong Label
            lblRandomNumber.Text = "Số ngẫu nhiên: " + randomNumber.ToString();
        }
    }
}