using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAmbientacao
{
    public partial class frmSomaNumeros : Form
    {
        public frmSomaNumeros()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            string primeiroValorDigitado = txtPrimeiroValor.Text.Trim();
            string segundoValorDigitado = txtSegundoValor.Text.Trim();  

            int primeiroValor = Convert.ToInt32(primeiroValorDigitado);
            int segundoValor = Convert.ToInt32(segundoValorDigitado);
            int resultado = primeiroValor + segundoValor;

            lblResultado.Text = "" + resultado.ToString();
        }
    }
}
