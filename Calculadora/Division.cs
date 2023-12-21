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
    public partial class Division : Form
    {
        public Division()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CDivision cDivision = new CDivision();
            try
            {
                float da = float.Parse(textBox1.Text);
                cDivision.GuardarDA(da);

                if (textBox2.Text != "")
                {
                    float db = float.Parse(textBox2.Text);
                    cDivision.GuardarDB(db);
                    cDivision.DResultado();
                    textBox3.Text = cDivision.DR.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar los elementos faltantes en la primera casilla");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CDivision cDivision = new CDivision();
            try 
            {
                float db = float.Parse(textBox2.Text);
                cDivision.GuardarDB(db);

                if (textBox1.Text != "") 
                {
                    float da = float.Parse(textBox1.Text);
                    cDivision.GuardarDA(da);
                    cDivision.DResultado();
                    textBox3.Text= cDivision.DR.ToString();
                }
            }
            catch (FormatException) 

            {
                MessageBox.Show("Debe ingresa los elementos faltantes de la segunda casilla");
            }
        }
    }
}
