using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace Calculadora
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void Suma_Load(object sender, EventArgs e)
        {

        }

        private void SumaA_TextChanged(object sender, EventArgs e)
        {
            CSuma csuma = new CSuma();
            try
            {
                float sa = float.Parse(SumaA.Text);
                csuma.GuardarNumeroA(sa);

                if (SumaB.Text != "")
                {
                    float sb = float.Parse(SumaB.Text);
                    csuma.GuardarNumeroB(sb);
                    csuma.GuardarSR();
                    SumaResultado.Text = csuma.SR.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en SumaA.");
            }

        }

        private void SumaB_TextChanged(object sender, EventArgs e)
        {
            CSuma csuma = new CSuma();
            try
            {
                float sb = float.Parse(SumaB.Text);
                csuma.GuardarNumeroB(sb);

                if (SumaA.Text != "")
                {
                    float sa = float.Parse(SumaA.Text);
                    csuma.GuardarNumeroA(sa);
                    csuma.GuardarSR();
                    SumaResultado.Text = csuma.SR.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido en SumaB.");
            }
        }

        private void SumaResultado_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

