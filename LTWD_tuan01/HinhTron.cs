using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp3
{
    public class HinhTron : HinhHoc
    {
        private int r;
        private ToaDo tam = new ToaDo();

        public HinhTron()
        {

        }

        public HinhTron(int r, double tamX, double tamY)
        {
            R = r;
            Tam.X = tamX;
            Tam.Y = tamY;
        }

        public int R { get => r; set => r = value; }
        public ToaDo Tam { get => tam; set => tam = value; }

        public override double DienTich()
        {
            double area = PI * Math.Pow(R, 2);
            return area;
        }
        public override double ChuVi()
        {
            double chuVi = 2 * PI * R;
            return chuVi;
        }
    }
}