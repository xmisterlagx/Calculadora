using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Calculadora
{
    internal class CDivision
    {
        public float DA { get; set; }
        public float DB { get; set; }
        public float DR { get; set; }

        public void GuardarDA(float da) 
        {
            DA = da;
        }

        public void GuardarDB(float db) 
        {
            DB = db;
        }

        public void DResultado() 
        {
            DR = DA / DB;
        }
    }
}
