namespace AppConfigCheckbox
{
    partial class FrmConfig
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
            this.chkExibirConfirmacao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkExibirConfirmacao
            // 
            this.chkExibirConfirmacao.AutoSize = true;
            this.chkExibirConfirmacao.Location = new System.Drawing.Point(24, 28);
            this.chkExibirConfirmacao.Name = "chkExibirConfirmacao";
            this.chkExibirConfirmacao.Size = new System.Drawing.Size(272, 20);
            this.chkExibirConfirmacao.TabIndex = 0;
            this.chkExibirConfirmacao.Text = "Exibir confirmação ao fechar a aplicação";
            this.chkExibirConfirmacao.UseVisualStyleBackColor = true;
            this.chkExibirConfirmacao.CheckedChanged += new System.EventHandler(this.chkExibirConfirmacao_CheckedChanged);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 244);
            this.Controls.Add(this.chkExibirConfirmacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExibirConfirmacao;
    }
}