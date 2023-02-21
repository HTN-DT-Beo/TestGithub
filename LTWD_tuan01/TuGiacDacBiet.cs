using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TuGiacDacBiet : DaGiac
    {
        public TuGiacDacBiet(double xA, double yA, double xB, double yB, double xC, double yC, double xD, double yD) 
        {
            DinhA.X = xA;
            DinhA.Y = yA;
            DinhB.X = xB;
            DinhB.Y = yB;
            DinhC.X = xC;
            DinhC.Y = yC;
            DinhD.X = xD;
            DinhD.Y = yD;
        }
        public override double DienTich()
        {
            return (kCachHaiDiem(DinhA, DinhB) * kCachHaiDiem(DinhA, DinhD));
        }
        public override double ChuVi()
        {
            return 2 * (kCachHaiDiem(DinhA, DinhB) + kCachHaiDiem(DinhA, DinhD));
        }
    }
}
