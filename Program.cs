using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        QuanLyXe quanLyXe = new QuanLyXe();
        QuanLySoHopDong quanLySoHopDong = new QuanLySoHopDong();
        public void Menu()
        {
            int menuSelection;
            do
            {
                Console.Clear();
                Console.WriteLine("--- QUẢN LÝ XE ---");
                Console.WriteLine("1 - Nhập thông tin xe");
                Console.WriteLine("2 - Hiển thị danh sách xe");
                Console.WriteLine("3 - Tìm kiếm xe");
                Console.WriteLine("4 - Xóa xe theo biển số");
                Console.WriteLine("--- QUẢN LÝ SỔ HỢP ĐỒNG ---");
                Console.WriteLine("5 - Tạo hợp đồng thuê xe");
                Console.WriteLine("6 - Hiển thị danh sách hợp đồng");
                Console.WriteLine("7 - Tìm kiếm hợp đồng");
                Console.WriteLine("8 - Xóa hợp đồng");
                Console.WriteLine("0 - Thoát");
                menuSelection = int.Parse(Console.ReadLine());
                switch (menuSelection)
                {
                    case 1:
                        quanLyXe.NhapDanhSachXe();
                        break;
                    case 2:
                        quanLyXe.InDanhSachXe();
                        break;
                    case 3:
                        quanLyXe.TimKiem();
                        break;
                    case 4:
                        quanLyXe.Xoa();
                        break;
                    case 5:
                        quanLySoHopDong.TaoHopDongMoi(quanLyXe);
                        break;
                    case 6:
                        quanLySoHopDong.HienThiDanhSach();
                        break;
                    case 7:
                        quanLySoHopDong.TimKiem();
                        break;
                    case 8:
                        quanLySoHopDong.Xoa();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Không có giá trị " + menuSelection + " trong menu");
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                        Console.ReadKey();
                        break;
                }
            } while (menuSelection != 0);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Program p = new Program();
            p.Menu();
        }
    }
}
