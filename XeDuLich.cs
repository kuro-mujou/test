using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class XeDuLich : Xe
    {
        private int SoChoNgoi;
        public int SoChoNgoi1 { get => SoChoNgoi; set => SoChoNgoi = value; }
        public XeDuLich() :base()
        {

        }
        public XeDuLich(string bienSo, string tenXe, int trongTai, DateTime ngayDangKiem, int tieuChuanBang,int soChoNgoi) 
        : base( bienSo,  tenXe,  trongTai,  ngayDangKiem,  tieuChuanBang)
        {
            SoChoNgoi = soChoNgoi;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số chỗ ngồi: ");
            try
            {
                SoChoNgoi = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nhập sai định dạng");
            }
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số chỗ ngồi: " + SoChoNgoi);
        }
    }
}
