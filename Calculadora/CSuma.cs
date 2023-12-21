using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Calculadora
{
    internal class CSuma
    {
        public float SA { get; set; }
        public float SB { get; set; }

        public float SR {  get; set; }

        public void GuardarNumeroA(float sa) 
        {
            SA = sa;
        }
        public void GuardarNumeroB(float sb)
        {
            SB = sb;
        }
        public void GuardarSR() 
        {
            SR = SA + SB;
        }
    }
}
