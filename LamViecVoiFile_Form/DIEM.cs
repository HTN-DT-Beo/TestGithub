using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DIEM
    {
        private double ToanCC;
        private double LyDC;
        private double HoaDC;

        public DIEM()
        {
            //throw new System.NotImplementedException();
        }

        public DIEM(double ToanCC, double LyDC, double HoaDC)
        {
            //throw new System.NotImplementedException();
            this.ToanCC = ToanCC;
            this.LyDC = LyDC;
            this.HoaDC = HoaDC;
        }

        public double TCC
        {
            get => ToanCC;
            set
            {
                ToanCC = value;
            }
        }

        public double LDC
        {
            get => LyDC;
            set
            {
                LyDC = value;
            }
        }
        public double HDC
        {
            get => HoaDC;
            set
            {
                HoaDC = value;
            }
        }
        public double TinhDTB()
        {
            //throw new System.NotImplementedException();
            double dtb = (HoaDC + LyDC + ToanCC) / 3;
            return dtb;
        }
    }
}
