using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class KhachHang : Nguoi
    {
        private string MaKhachHang;
        private DateTime HanBangLai;

        public string MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
        public DateTime HanBangLai1 { get => HanBangLai; set => HanBangLai = value; }

        public override void Nhap()
        {
            Console.Clear();
            Console.WriteLine("Nhập thông tin khách hàng");
            Console.WriteLine("Nhập CMND");
            CMND1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên khách hàng");
            HoTen1 = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ");
            DiaChi1 = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            DienThoai1 = Console.ReadLine();
            Console.WriteLine("Nhập mã khách hàng");
            MaKhachHang1 = Console.ReadLine();
            Console.WriteLine("Nhập ngày hạn bằng lái xe");
            HanBangLai1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Lưu thông tin thành công");
            Console.WriteLine("Bấm phím bất kì để tiếp tục...");
            Console.ReadKey();
        }

        public override void Xuat()
        {
            Console.WriteLine("Mã khách hàng " + MaKhachHang1);
            Console.WriteLine("CMND " + CMND1);
            Console.WriteLine("Họ tên khách hàng " + HoTen1);
            Console.WriteLine("Địa chỉ " + DiaChi1);
            Console.WriteLine("Số điện thoại " + DienThoai1);
            Console.WriteLine("Ngày hạn bằng lái xe " + HanBangLai1);
        }
    }
}
