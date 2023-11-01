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

namespace App_Salvar_Conteudo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tmrHorarioStatus_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            stsHorarioAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracao configuracao = new frmConfiguracao();
            configuracao.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool devoExibirConfirmacao = Properties.Settings.Default.dialogo;
            if (devoExibirConfirmacao)
            {
                string msgTitulo = "Confirmacao";
                string msgTexto = "Deseja realmente fechar a aplicacao?";


                DialogResult dialogResult = MessageBox.Show(msgTexto, msgTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void mnuArquivoAbrir_Click(object sender, EventArgs e)
        {
            using ( OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Text (*.txt)|*.txt";
                ofd.Title = "Abrir arquivo";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string caminhoDoArquivo = ofd.FileName;

                    try
                    {
                        string conteudo = File.ReadAllText(caminhoDoArquivo);
                        rtxConteudoEditor.Text = conteudo;
                    } catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao tentar abrir o arquivo {caminhoDoArquivo}", 
                            "Error", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
