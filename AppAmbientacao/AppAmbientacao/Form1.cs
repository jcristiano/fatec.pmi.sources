using Microsoft.Win32;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTrocarMensagem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = "Clicado";
            trocarMensagem();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                trocarMensagem();
            }
        }


        private void trocarMensagem()
        {
            string nomeDigitado = txtNome.Text;

            lblMensagem.Text = $"Olá {nomeDigitado}";
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            txtNome.Focus();            
        }

        private void btnAbrirSoma_Click(object sender, EventArgs e)
        {
            Form formulario = new frmSomaNumeros();
            formulario.ShowDialog();
        }
    }
}
