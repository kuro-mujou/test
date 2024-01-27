using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class Nguoi
    {
        private long CMND;
        private string HoTen;
        private string DiaChi;
        private string DienThoai;
        public long CMND1 { get => CMND; set => CMND = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
        public abstract void Nhap();
        public abstract void Xuat();
    }
}
