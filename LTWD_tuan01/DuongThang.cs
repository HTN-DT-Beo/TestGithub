using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class DuongThang : HinhHoc
    {
        private double thamSoA;
        private double thamSoB;
        private double thamSoC;
        public DuongThang()
        {

        }
        public DuongThang(double thamSoA, double thamSoB, double thamSoC)
        {
            ThamSoA = thamSoA;
            ThamSoB = thamSoB;
            ThamSoC = thamSoC;
        }

        public double ThamSoA { get => thamSoA; set => thamSoA = value; }
        public double ThamSoB { get => thamSoB; set => thamSoB = value; }
        public double ThamSoC { get => thamSoC; set => thamSoC = value; }

        public override double ChuVi()
        {
            return 0;
        }

        public override double DienTich()
        {
            return 0;
        }
    }
}