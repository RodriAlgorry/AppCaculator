using AppCaculator.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCaculator.FE
{
    public partial class frmCalculadora : Form
    {
        public Calculadora oCalculadora = new Calculadora();

        public frmCalculadora()
        {
            InitializeComponent();
            oCalculadora.Resultado = 0;
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            if (oCalculadora.Resultado == 0)
            {
                oCalculadora.Operador1 = Convert.ToInt32(txtOperador1.Text);
                oCalculadora.Suma();
                lblResultado.Text = oCalculadora.Resultado.ToString();
            }
            else
            {
                oCalculadora.Operador1 = Convert.ToInt32(txtOperador1.Text);
                oCalculadora.Suma();
                lblResultado.Text = oCalculadora.Resultado.ToString();
            }
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            oCalculadora.Operador1 = Convert.ToInt32(txtOperador1.Text);
            oCalculadora.Suma();
            lblResultado.Text = oCalculadora.Resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oCalculadora = null;
            oCalculadora = new Calculadora();
            txtOperador1.Text = "0";
            lblResultado.Text = "";
            txtOperador1.Focus();

        }
    }
}
