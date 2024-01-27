using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class NhanVien : Nguoi
    {
        private string MaNhanVien;
        private DateTime NgayVaoCoQuan;

        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public DateTime NgayVaoCoQuan1 { get => NgayVaoCoQuan; set => NgayVaoCoQuan = value; }

        public override void Nhap()
        {
            Console.Clear();
            Console.WriteLine("Nhập thông tin Nhân viên");
            Console.WriteLine("Nhập CMND");
            CMND1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên nhân viên");
            HoTen1 = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ");
            DiaChi1 = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            DienThoai1 = Console.ReadLine();
            Console.WriteLine("Nhập mã nhân viên");
            MaNhanVien1 = Console.ReadLine();
            Console.WriteLine("Nhập ngày vào cơ quan");
            NgayVaoCoQuan1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Lưu thông tin thành công");
            Console.WriteLine("Bấm phím bất kì để tiếp tục...");
            Console.ReadKey();
        }

        public override void Xuat()
        {
            Console.WriteLine("Mã nhân viên " + MaNhanVien1);
            Console.WriteLine("CMND " + CMND1);
            Console.WriteLine("Họ tên nhân viên " + HoTen1);
            Console.WriteLine("Địa chỉ " + DiaChi1);
            Console.WriteLine("Số điện thoại " + DienThoai1);
            Console.WriteLine("Ngày vào cơ quan " + NgayVaoCoQuan1);
        }
    }
}
