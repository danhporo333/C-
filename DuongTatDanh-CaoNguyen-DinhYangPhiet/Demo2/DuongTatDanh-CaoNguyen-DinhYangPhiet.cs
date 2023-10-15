using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Book> s = new List<Book>();
            
            while (true)  
            {
                Console.WriteLine("**********MENU**********");
                Console.WriteLine("1. Thêm một cuốn sách.");
                Console.WriteLine("2. Xóa một cuốn sách.");
                Console.WriteLine("3. Thay đổi thông tin của một cuốn sách.");
                Console.WriteLine("4. Xuất thông tin tất cả các cuốn sách.");
                Console.WriteLine("5. Tìm kiếm cuốn sách có tên chứa từ 'Lập trình'.");
                Console.WriteLine("6. Lấy danh sách sách: Nhập số K và giá tiền P, trả về tối đa K cuốn sách có giá tiền ≤ P\r\n(Lưu ý: K và P là 2 số nguyên dương lớn hơn 0).");
                Console.WriteLine("7. Nhập danh sách các tác giả từ bàn phím và hiển thị tất cả cuốn sách của những tác giả đó?");
                Console.WriteLine("8. Thoát.");

                Console.Write("Nhập lựa chọn của bạn: ");
                int chon = int.Parse(Console.ReadLine());   
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("****************************");
                        Book sach = new Book();
                        sach.Input();
                        s.Add(sach);
                        break;
                    case 2:
                        Console.WriteLine("****************************");
                        Console.Write("Nhập mã sách cần xóa: ");
                        int maSachCanXoa = int.Parse(Console.ReadLine());
                        //tìm một mã sách cần xóa trong danh sách
                        Book sachCanXoa = s.Find(p => p.masach == maSachCanXoa);
                        s.Remove(sachCanXoa);
                        Console.WriteLine(sachCanXoa != null ? "cuốn sách đã được xóa" : "không tìm thấy cuốn sách");
                        break;
                    case 3:
                        Console.WriteLine("****************************");
                        Console.Write("Nhập mã cuốn sách cần thay đổi thông tin: ");
                        int maSachCanThayDoi = int.Parse(Console.ReadLine());
                        //tìm một mã sách cần xóa trong danh sách để thay đổi thông tin
                        Book SachCanThayDoi = s.Find(p => p.masach ==  maSachCanThayDoi);
                        Console.WriteLine(SachCanThayDoi != null ? "tìm thấy sách" : "không tìm thấy sách");
                        SachCanThayDoi?.Input();
                        break;
                    case 4:
                        Console.WriteLine("****************************");
                        Console.WriteLine("Danh sách các cuốn sách:");
                        XuatDS(s);
                        break;
                    case 5:
                        Console.WriteLine("****************************");
                        Console.WriteLine("Sách có chứa chữ 'lập trình'");
                        var tensach = s.Where(p => p.tensach == "Lap trinh");
                        XuatDS(s);
                        break;
                    case 6:

                        break;
                    case 7:
                        Console.WriteLine("****************************");
                        Console.Write("Nhập tên tác giả để tìm kiếm sách: ");
                        String tenTacGiaCanTim = Console.ReadLine();
                        var tacgia = s.Where(p => p.tacgia == tenTacGiaCanTim);
                        XuatDS(s);
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                }
            } 
            Console.ReadKey();
        }

        private static void XuatDS(List<Book> sach)
        {
            if (sach.Count > 0)
            {
                foreach (Book s in sach)
                {
                    s.Output();
                }
            }
            else
            {
                Console.WriteLine("Danh sách rỗng");
            }
        }
    }
}
