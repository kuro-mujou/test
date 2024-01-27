using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class QuanLyXe
    {
        private Dictionary<string, Xe> DanhSachXe = new Dictionary<string, Xe>();
        public QuanLyXe()
        {

        }

        public void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Nhập biển số xe cần tìm: ");
            string bienSoXeTim = Console.ReadLine();
            if (DanhSachXe.ContainsKey(bienSoXeTim))
            {
                DanhSachXe[bienSoXeTim].Xuat();
                Console.WriteLine("Bạn có muốn xóa xe này không?");
                Console.WriteLine("1 - Có  |  2 - Không");
                int selection = int.Parse(Console.ReadLine());
                if(selection == 1)
                    DanhSachXe.Remove(bienSoXeTim);
            }
            else
            {
                Console.WriteLine("Không có xe cần tìm trong danh sách");
            }
            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
            Console.ReadKey();
        }

        public Xe TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Nhập biển số xe cần tìm: ");
            string bienSoXeTim = Console.ReadLine();
            if(DanhSachXe.ContainsKey(bienSoXeTim))
            {
                DanhSachXe[bienSoXeTim].Xuat();
                Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                Console.ReadKey();
                return DanhSachXe[bienSoXeTim];
            }    
            else
            {
                Console.WriteLine("Không có xe cần tìm trong danh sách");
                Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                Console.ReadKey();
                return null;
            }
        }

        public void InDanhSachXe()
        {
            Console.Clear();
            int count = 0;
            Console.WriteLine("DANH SÁCH XE");
            foreach(Xe xe in DanhSachXe.Values)
            {
                Console.WriteLine("\nXe số " + ++count);
                xe.Xuat();
            }    
            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
            Console.ReadKey();
        }

        public void NhapDanhSachXe()
        {
            Xe xe;
            int menuSelection;
            do
            {
                Console.Clear();
                Console.WriteLine("Nhập thông tin xe: ");
                Console.WriteLine("1 - Xe Du Lịch");
                Console.WriteLine("2 - Xe Chở Hàng");
                Console.WriteLine("0 - Thoát nhập thông tin");
                menuSelection = int.Parse(Console.ReadLine());
                switch (menuSelection)
                {
                    case 1:
                        xe = new XeDuLich();
                        try
                        {
                            xe.Nhap();
                            DanhSachXe.Add(xe.BienSo1, xe);
                            Console.WriteLine("Nhập dữ liệu thành công");
                            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Nhập dữ liệu thất bại");
                            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        try
                        {
                            xe = new XeChoHang();
                            xe.Nhap();
                            DanhSachXe.Add(xe.BienSo1, xe);
                            Console.WriteLine("Nhập dữ liệu thành công");
                            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                            Console.ReadKey();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Nhập dữ liệu thất bại");
                            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                            Console.ReadKey();
                        }
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
    }
}
