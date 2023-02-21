using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamViecVoiFile_Form
{
    public class DaGiac
    {
        private ToaDo dinhA = new ToaDo();
        private ToaDo dinhB = new ToaDo();
        private ToaDo dinhC = new ToaDo();
        private ToaDo dinhD = new ToaDo();

        public DaGiac()
        {
        }
        public ToaDo DinhA { get => dinhA; set => dinhA = value; }
        public ToaDo DinhB { get => dinhB; set => dinhB = value; }
        public ToaDo DinhC { get => dinhC; set => dinhC = value; }
        public ToaDo DinhD { get => dinhD; set => dinhD = value; }

      
    }

    
}