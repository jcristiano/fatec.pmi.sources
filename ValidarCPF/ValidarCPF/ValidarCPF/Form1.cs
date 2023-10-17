using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarCPF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnValidarCPF_Click(object sender, EventArgs e)
        {
            string cpfDigitado = txtCpfEntrada.Text.Trim();

            if (cpfDigitado.Length != 11 || string.IsNullOrWhiteSpace(cpfDigitado))
            {
                MessageBox.Show("Você não digitou a quantidade correta de digitos de um CPF",
                    "Erro", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else
            {
                string cpfParcial = cpfDigitado.Substring(0, 9);

                int soma = 0;

                
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpfParcial[i].ToString()) * (10 - i);
                }

                int resto = soma % 11;
                resto = resto < 2 ? 0 : 11 - resto;

                cpfParcial += resto.ToString();
                soma = 0;
                
                for(int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpfParcial[i].ToString()) * (11 - i);
                }

                if ( soma == 0)
                {
                    MessageBox.Show($"Valor de entrada indevido: {cpfParcial}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                } else
                {

                    resto = soma % 11;
                    resto = resto < 2 ? 0 : 11 - resto;
                    cpfParcial += resto.ToString();

                    if ( cpfDigitado.Equals(cpfParcial))
                    {
                        MessageBox.Show("Você digitou um CPF válido", 
                            "Sucesso", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("Você digitou um CPF inválido", 
                            "Erro",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Exclamation);
                    }
                }                
            }
        }

        private void txtCpfEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnValidarCPF_Click(sender, e);
            } else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            
        }
    }
}
