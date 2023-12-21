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
    public partial class Multiplicacion : Form
    {
        public Multiplicacion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CMultiplicacion cmultiplicacion = new CMultiplicacion();
            try
            {
                float ma = float.Parse(textBox1.Text);
                cmultiplicacion.GuardarMA(ma);

                if (textBox2.Text != "")
                {
                    float mb = float.Parse(textBox2.Text);
                    cmultiplicacion.GuardarMB(mb);
                    cmultiplicacion.MResultado();
                    textBox3.Text = cmultiplicacion.MR.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe Ingresar los datos faltantes en la primera casilla");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CMultiplicacion cMultiplicacion = new CMultiplicacion();
            try
            {
                float mb = float.Parse(textBox2.Text);
                cMultiplicacion.GuardarMB(mb);

                if (textBox1.Text != "") 
                {
                    float ma = float.Parse (textBox1.Text);
                    cMultiplicacion.GuardarMA(ma);
                    cMultiplicacion.MResultado();
                    textBox3.Text = cMultiplicacion.MR.ToString() ;
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("Debe ingresar los elementos faltantes en la segunda casilla"); 
            }
        }
    }
}
