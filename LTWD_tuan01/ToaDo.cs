using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamViecVoiFile_Form
{
    public class ToaDo
    {
        private double x;
        private double y;
        public ToaDo()
        {

        }
        public ToaDo(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        
    }
}