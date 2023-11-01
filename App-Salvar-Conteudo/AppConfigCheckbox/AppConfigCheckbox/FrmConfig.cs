using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfigCheckbox
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void chkExibirConfirmacao_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dialogo = 
                chkExibirConfirmacao.Checked;
            Properties.Settings.Default.Save();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            chkExibirConfirmacao.Checked = 
                Properties.Settings.Default.dialogo;
        }
    }
}
