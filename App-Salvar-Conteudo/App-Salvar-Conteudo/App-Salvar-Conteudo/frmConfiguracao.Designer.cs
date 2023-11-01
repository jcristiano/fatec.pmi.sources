namespace App_Salvar_Conteudo
{
    partial class frmConfiguracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkPedirCofirmacao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkPedirCofirmacao
            // 
            this.chkPedirCofirmacao.AutoSize = true;
            this.chkPedirCofirmacao.Location = new System.Drawing.Point(12, 24);
            this.chkPedirCofirmacao.Name = "chkPedirCofirmacao";
            this.chkPedirCofirmacao.Size = new System.Drawing.Size(260, 20);
            this.chkPedirCofirmacao.TabIndex = 0;
            this.chkPedirCofirmacao.Text = "Pedir confirmação ao fechar aplicação";
            this.chkPedirCofirmacao.UseVisualStyleBackColor = true;
            this.chkPedirCofirmacao.CheckedChanged += new System.EventHandler(this.chkPedirCofirmacao_CheckedChanged);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 270);
            this.Controls.Add(this.chkPedirCofirmacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracao";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPedirCofirmacao;
    }
}