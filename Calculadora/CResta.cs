using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;


namespace Calculadora
{
    internal class CResta
    {
        public float RA {  get; set; }
        public float RB { get; set; }

        public float RR { get; set; }

        public void GuardarRA(float ra) 
        {
            RA = ra;
        }
        public void GuardarRB(float rb)
        {
            RB = rb;        
        }
        public void GuardarRR() 
        {
            RR = RA - RB;
        }
    }
}
