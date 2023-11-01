using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfigCheckbox
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmConfig();
            formulario.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Texto (*.txt)|*.txt";
                ofd.Title = "Abrir Arquivo";
                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string caminhoDoArquivo = ofd.FileName;
                    try
                    {
                        string conteudo = File.ReadAllText(caminhoDoArquivo);
                        rtxTexto.Text = conteudo;                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro " +
                            $"ao abrir o arquivo: {ex.Message}");
                    }
                }                
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()) {
                sfd.Filter = "Arquivos de Texto (*.txt)|*.txt";
                sfd.Title = "Abrir Arquivo";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(filePath, false))
                        {
                            sw.WriteLine(rtxTexto.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao tentar salvar o arquivo:" + ex.Message);
                    }
                }
            }
        }
    }
}
