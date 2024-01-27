using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Xe
    {
        private string BienSo;
        private string TenXe;
        private int TrongTai;
        private DateTime NgayDangKiem;
        private int TieuChuanBang;

        public string BienSo1 { get => BienSo; set => BienSo = value; }
        public string TenXe1 { get => TenXe; set => TenXe = value; }
        public int TrongTai1 { get => TrongTai; set => TrongTai = value; }
        public DateTime NgayDangKiem1 { get => NgayDangKiem; set => NgayDangKiem = value; }
        public int TieuChuanBang1 { get => TieuChuanBang; set => TieuChuanBang = value; }
        
        public Xe()
        {

        }

        public Xe(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang)
        {
            BienSo = bienSo;
            TenXe = tenXe;
            TrongTai = trongTai;
            NgayDangKiem = ngayDangKiem;
            TieuChuanBang = tieuChuanBang;
        }

        public virtual void Nhap()
        {
            try
            {
                Console.WriteLine("Nhập biển số xe");
                BienSo = Console.ReadLine();
                Console.WriteLine("Nhập tên xe");
                TenXe = Console.ReadLine();
                Console.WriteLine("Nhập trọng tải xe");
                TrongTai = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập ngày đăng kiểm");
                NgayDangKiem = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhập tiêu chuẩn bằng");
                TieuChuanBang = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nhập sai định dạng");
            }
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Biển số xe: " + BienSo);
            Console.WriteLine("Tên xe: " + TenXe);
            Console.WriteLine("Trọng tải: " + TrongTai);
            Console.WriteLine("Ngày đăng kiểm: " + NgayDangKiem);
            Console.WriteLine("Số tiêu chuẩn bằng: " + TieuChuanBang);
        }
    }
}
