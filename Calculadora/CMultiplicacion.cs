using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Calculadora
{
    internal class CMultiplicacion
    {
        public float MA { get; set; }
        public float MB { get; set; }

        public float MR { get; set; }


        public void GuardarMA(float ma) 
        {
            MA = ma;
        }

        public void GuardarMB(float mb) 
        {
            MB = mb;
        }

        public void MResultado() 
        {
            MR = MA * MB;
        }

    }
}
