using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Salvar_Conteudo
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void chkPedirCofirmacao_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dialogo = chkPedirCofirmacao.Checked;
            Properties.Settings.Default.Save();
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            chkPedirCofirmacao.Checked = Properties.Settings.Default.dialogo;
        }
    }
}
