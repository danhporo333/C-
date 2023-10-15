using Ket_noi_database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ket_noi_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var products = context.Product.ToList();
            var Category = context.Categorys.ToList();
            cmbLoai.DataSource = Category;
            cmbLoai.DisplayMember = "CategoryName";
            cmbLoai.ValueMember = "CategoryID";


            // cach 2
            dataGridView1.Rows.Clear();
            foreach (var p in products)
            {
                int newRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[newRow].Cells[0].Value = p.ProductID;
                dataGridView1.Rows[newRow].Cells[1].Value = p.ProductName;
                dataGridView1.Rows[newRow].Cells[2].Value = p.Price;
                dataGridView1.Rows[newRow].Cells[3].Value = p.Categorys.CategoryID + " : " + p.Categorys.CategoryName;
            }
        }

        //dùng để thêm dữ liệu và database
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product s = new Product();
                s.ProductID = MaSP.Text;
                s.ProductName = TenSP.Text;
                s.Price = int.Parse(Gia.Text);
                s.CategoryID = int.Parse(cmbLoai.SelectedValue.ToString());


                var db = new Model1();
                db.Product.Add(s);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                Form1_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Model1();
                Product find = db.Product.FirstOrDefault(p => p.ProductID == MaSP.Text);
                if (find != null)
                {

                    find.ProductName = TenSP.Text;
                    find.Price = int.Parse(Gia.Text);
                    find.CategoryID = int.Parse(cmbLoai.SelectedValue.ToString());
                    db.SaveChanges();
                    MessageBox.Show("update thanh cong");
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new Model1();
            Product find = db.Product.FirstOrDefault(p => p.ProductID == MaSP.Text);
            if (find != null)
            {
                db.Product.Remove(find);
                db.SaveChanges();
                MessageBox.Show("xoa thanh cong");
                Form1_Load(sender, e);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string masp = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var db = new Model1();
            Product find = db.Product.FirstOrDefault(p => p.ProductID == masp);
            if (find != null)
            {
                MaSP.Text = masp;
                TenSP.Text = find.ProductName;
                Gia.Text = find.Price.ToString();
                cmbLoai.SelectedValue = find.CategoryID;
            }
        }
    }
    }
