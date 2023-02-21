using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public abstract class HinhHoc
    {
        protected const double PI = 3.16;
        public HinhHoc()
        {
            
        }
        public abstract double DienTich();
        public abstract double ChuVi();
        public static double kCachHaiDiem(ToaDo diemA, ToaDo diemB)
        {
            double length = Math.Sqrt(Math.Pow((diemB.X - diemA.X), 2) + Math.Pow((diemB.Y - diemA.Y), 2));
            return length;
        }
        public static double KcDiemDenDuong(DuongThang duongThang, ToaDo diem)
        {
            double tuSo = Math.Abs(duongThang.ThamSoA * diem.X + duongThang.ThamSoB * diem.Y + duongThang.ThamSoC);
            double mauSo = Math.Sqrt(Math.Pow(duongThang.ThamSoA, 2) + Math.Pow(duongThang.ThamSoB, 2));
            return tuSo / mauSo;
        }
    }
}