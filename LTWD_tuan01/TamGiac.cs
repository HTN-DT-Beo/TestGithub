using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class TamGiac : DaGiac
    {
        public TamGiac()
        {

        }
        public TamGiac(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            DinhA.X = xA;
            DinhA.Y = yA;
            DinhB.X = xB;
            DinhB.Y = yB;
            DinhC.X = xC;
            DinhC.Y = yC;
        }
        public override double DienTich()
        {
            double temp01 = (DinhB.X - DinhA.X) * (DinhC.Y - DinhA.Y);
            double temp02 = (DinhC.X - DinhA.X) * (DinhB.Y - DinhA.Y);
            double area = 0.5 * (Math.Abs(temp01 - temp02));
            return area;
        }
        public override double ChuVi()
        {
            double canhAB = kCachHaiDiem(DinhA, DinhB);
            double canhAC = kCachHaiDiem(DinhA, DinhC);
            double canhBC = kCachHaiDiem(DinhB, DinhC);
            return canhAB + canhAC + canhBC;
        }
    }
}