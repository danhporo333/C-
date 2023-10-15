using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Book
    {
        public int masach;
        public string tensach;
        public string tacgia;
        public double dongia;

        //phương thức khởi tạo
        #region Constructor
        public Book()
        {
        }

        public Book(int masach, string tensach, string tacgia, double dongia)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacgia = tacgia;
            this.dongia = dongia;
        }
        #endregion
        
        public void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập mã sách: ");
            masach = int.Parse(Console.ReadLine());

            Console.Write("Nhập tên sách: ");
            tensach = Console.ReadLine();

            Console.Write("Nhập vào tên tác giả: ");
            tacgia = Console.ReadLine();

            Console.Write("Nhập vào đơn giá: ");
            dongia = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("Mã sách: {0}, Tên sách: {1}, tác giả: {2}, Đơn Giá: {3}",masach,tensach,tacgia,dongia);
        }

    }
}
