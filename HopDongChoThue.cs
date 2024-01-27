using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class HopDongChoThue
    {
        private string SoHopDong;
        private Xe xe;
        private Nguoi NhanVien;
        private Nguoi KhachHang;
        private int SoNgayThue;
        private double DonGia;
        private DateTime NgayThue;

        public string SoHopDong1 { get => SoHopDong; set => SoHopDong = value; }
        public int SoNgayThue1 { get => SoNgayThue; set => SoNgayThue = value; }
        public double DonGia1 { get => DonGia; set => DonGia = value; }
        public DateTime NgayThue1 { get => NgayThue; set => NgayThue = value; }
        public Xe Xe { get => xe; set => xe = value; }
        public Nguoi NhanVien1 { get => NhanVien; set => NhanVien = value; }
        public Nguoi KhachHang1 { get => KhachHang; set => KhachHang = value; }
        public HopDongChoThue()
        {
            xe = new Xe();
            NhanVien = new NhanVien();
            KhachHang = new KhachHang();
        }

        public void Nhap(QuanLyXe quanLyXe)
        {
            do
            {
                xe = quanLyXe.TimKiem();
            } while (xe == null);
            NhanVien.Nhap();
            KhachHang.Nhap();
            Console.Clear();
            Console.WriteLine("Nhập số hợp đồng");
            SoHopDong = Console.ReadLine();
            Console.WriteLine("Nhập ngày thuê xe");
            NgayThue = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số ngày thuê xe");
            SoNgayThue = int.Parse(Console.ReadLine());
            TinhDonGia();
            Console.Clear();
            Console.WriteLine("Lưu thông tin thành công");
            Console.WriteLine("Thông tin hợp đồng mới khởi tạo");
            Xuat();
            Console.WriteLine("Bấm phím bất kì để tiếp tục...");
            Console.ReadKey();
        }
        public void Xuat()
        {
            Console.WriteLine("\nThông tin xe cho thuê:");
            xe.Xuat();
            Console.WriteLine("\nThông tin nhân viên làm việc:");
            NhanVien.Xuat();
            Console.WriteLine("\nThông tin khách hàng:");
            KhachHang.Xuat();
            Console.WriteLine("\nĐơn giá: " + DonGia);
            Console.WriteLine("Thành tiền: " + ThanhTien());
        }
        private void TinhDonGia()
        {
            if (xe.GetType().Equals(typeof(XeChoHang)))
                DonGia = 500000;
            else if (xe.GetType().Equals(typeof(XeDuLich)))
            {
                XeDuLich xeDuLich = (XeDuLich)xe;
                if (xeDuLich.SoChoNgoi1 <= 5)
                    DonGia = 500000;
                else if (xeDuLich.SoChoNgoi1 <= 7)
                    DonGia = 700000;
                else
                    DonGia = 1000000;
            }
        }
        public double ThanhTien()
        {
            return DonGia * SoNgayThue;
        }
    }
}
