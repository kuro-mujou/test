using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class QuanLySoHopDong
    {
        private Dictionary<string, HopDongChoThue> SoCai = new Dictionary<string, HopDongChoThue>();
        public QuanLySoHopDong()
        {

        }

        public void TaoHopDongMoi(QuanLyXe quanLyXe)
        {
            HopDongChoThue hopDong = new HopDongChoThue();
            hopDong.Nhap(quanLyXe);
            try
            {
                SoCai.Add(hopDong.SoHopDong1, hopDong);
            }
            catch (Exception)
            {
                Console.WriteLine("thêm vào sổ không thành công");
                Console.WriteLine("Số hợp đồng này đã có trong danh sách");
                Console.WriteLine("nhấn phím bất kì để tiếp tục");
                Console.ReadKey();
            }
            
        }

        public void HienThiDanhSach()
        {
            Console.Clear();
            int count = 0;
            Console.WriteLine("DANH SÁCH HỢP ĐỒNG");
            foreach (HopDongChoThue hopDong in SoCai.Values)
            {
                Console.WriteLine("Hợp đồng " + ++count);
                hopDong.Xuat();
            }   
            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
            Console.ReadKey();
        }
        public void Xoa()
        {
            Console.Clear();
            Console.WriteLine("Nhập số hợp đồng cần tìm: ");
            string soHopDong = Console.ReadLine();
            if (SoCai.ContainsKey(soHopDong))
            {
                SoCai[soHopDong].Xuat();
                Console.WriteLine("Bạn có muốn xóa hợp đồng này không?");
                Console.WriteLine("1 - Có  |  2 - Không");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    SoCai.Remove(soHopDong);
                    Console.WriteLine("Xóa hợp đồng thành công");
                }
            }
            else
            {
                Console.WriteLine("Không có xe cần tìm trong danh sách");
            }
            Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
            Console.ReadKey();
        }

        public HopDongChoThue TimKiem()
        {
            Console.Clear();
            Console.WriteLine("Nhập số hợp đồng cần tìm: ");
            string soHopDong = Console.ReadLine();
            if (SoCai.ContainsKey(soHopDong))
            {
                SoCai[soHopDong].Xuat();
                Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                Console.ReadKey();
                return SoCai[soHopDong];
            }
            else
            {
                Console.WriteLine("Không có xe cần tìm trong danh sách");
                Console.WriteLine("Nhấn phím bất kì để tiếp tục...");
                Console.ReadKey();
                return null;
            }
        }
    }
}
