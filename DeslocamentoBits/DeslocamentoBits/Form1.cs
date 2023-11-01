using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeslocamentoBits
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            lblResultado.Left = (this.Width - lblResultado.Width) / 2;
        }

        private void lblResultado_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Left = (this.Width - lblResultado.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int primeiroValor = 0;                
            int segundoValor = 0;

            int.TryParse(txtPrimeiro.Text, out primeiroValor);
            int.TryParse(txtSegundo.Text, out segundoValor);
            
            int resultado = 0;

            RadioButton rbSelected = null;
            foreach(RadioButton radioButton in gpbOperadores.Controls)
            {
                if (radioButton.Checked)
                {
                    rbSelected = radioButton;
                }
            }

            //MessageBox.Show(rbSelected.Tag.ToString());

            switch (rbSelected.Tag.ToString())
            {
                case "E":
                    resultado = primeiroValor & segundoValor; break;
                case "OR":
                    resultado = primeiroValor | segundoValor; break;
                case "XOR": 
                    resultado = primeiroValor ^ segundoValor; break;
                case "LEFT":
                    resultado = primeiroValor << 1; break;
                case "RIGHT":
                    resultado = primeiroValor >> 1; break;
            }

            lblResultado.Text = resultado.ToString();
        }

        private void rbtDescolamentoEsquerda_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtDescolamentoDireita_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
