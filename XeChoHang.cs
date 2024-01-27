using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class XeChoHang : Xe
    {
        private double SoTan;
        public double SoTan1 { get => SoTan; set => SoTan = value; }
        public XeChoHang() : base()
        {

        }
        public XeChoHang(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang, int soTan)
        : base(bienSo, tenXe, trongTai, ngayDangKiem, tieuChuanBang)
        {
            SoTan = soTan;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số tấn hàng: ");
            try
            {
                SoTan = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nhập sai định dạng");
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số tấn hàng: " + SoTan);
        }
    }
}
