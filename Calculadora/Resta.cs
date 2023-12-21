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
    public partial class Resta : Form
    {
        public Resta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CResta cresta = new CResta();
            try
            {
                float ra = float.Parse(textBox1.Text);
                cresta.GuardarRA(ra);

                if (textBox2.Text != "")
                {
                    float rb = float.Parse(textBox2.Text);
                    cresta.GuardarRB(rb);
                    cresta.GuardarRR();
                    textBox3.Text = cresta.RR.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar los datos faltantes en la primera casilla");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CResta cResta = new CResta();
            try
            {
                float rb = float.Parse(textBox2.Text);
                cResta.GuardarRB(rb);

                if (textBox1.Text != "")
                {
                    float ra = float.Parse(textBox1.Text);
                    cResta.GuardarRA(ra);
                    cResta.GuardarRR();
                    textBox3.Text = cResta.RR.ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Debe Ingresar los datos faltantes en la segunda casilla");
            }
        }
    }
}
