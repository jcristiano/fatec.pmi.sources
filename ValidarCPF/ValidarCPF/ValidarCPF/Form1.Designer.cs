namespace ValidarCPF
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDigiteOCpf = new System.Windows.Forms.Label();
            this.txtCpfEntrada = new System.Windows.Forms.TextBox();
            this.btnValidarCPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDigiteOCpf
            // 
            this.lblDigiteOCpf.AutoSize = true;
            this.lblDigiteOCpf.Location = new System.Drawing.Point(12, 9);
            this.lblDigiteOCpf.Name = "lblDigiteOCpf";
            this.lblDigiteOCpf.Size = new System.Drawing.Size(106, 20);
            this.lblDigiteOCpf.TabIndex = 0;
            this.lblDigiteOCpf.Text = "Digite o CPF:";
            // 
            // txtCpfEntrada
            // 
            this.txtCpfEntrada.Location = new System.Drawing.Point(12, 32);
            this.txtCpfEntrada.MaxLength = 11;
            this.txtCpfEntrada.Name = "txtCpfEntrada";
            this.txtCpfEntrada.Size = new System.Drawing.Size(437, 22);
            this.txtCpfEntrada.TabIndex = 1;
            this.txtCpfEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfEntrada_KeyPress);
            // 
            // btnValidarCPF
            // 
            this.btnValidarCPF.Location = new System.Drawing.Point(15, 77);
            this.btnValidarCPF.Name = "btnValidarCPF";
            this.btnValidarCPF.Size = new System.Drawing.Size(434, 23);
            this.btnValidarCPF.TabIndex = 2;
            this.btnValidarCPF.Text = "Valida&r CPF";
            this.btnValidarCPF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidarCPF.UseVisualStyleBackColor = true;
            this.btnValidarCPF.Click += new System.EventHandler(this.btnValidarCPF_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 124);
            this.Controls.Add(this.btnValidarCPF);
            this.Controls.Add(this.txtCpfEntrada);
            this.Controls.Add(this.lblDigiteOCpf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigiteOCpf;
        private System.Windows.Forms.TextBox txtCpfEntrada;
        private System.Windows.Forms.Button btnValidarCPF;
    }
}

