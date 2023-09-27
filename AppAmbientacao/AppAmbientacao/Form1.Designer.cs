namespace AppAmbientacao
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnTrocarMensagem = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAbrirSoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(72, 16);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Olá Mundo";
            // 
            // btnTrocarMensagem
            // 
            this.btnTrocarMensagem.Location = new System.Drawing.Point(15, 100);
            this.btnTrocarMensagem.Name = "btnTrocarMensagem";
            this.btnTrocarMensagem.Size = new System.Drawing.Size(272, 23);
            this.btnTrocarMensagem.TabIndex = 1;
            this.btnTrocarMensagem.Text = "Trocar Mensagem";
            this.btnTrocarMensagem.UseVisualStyleBackColor = true;
            this.btnTrocarMensagem.Click += new System.EventHandler(this.btnTrocarMensagem_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // btnAbrirSoma
            // 
            this.btnAbrirSoma.Location = new System.Drawing.Point(15, 140);
            this.btnAbrirSoma.Name = "btnAbrirSoma";
            this.btnAbrirSoma.Size = new System.Drawing.Size(272, 23);
            this.btnAbrirSoma.TabIndex = 3;
            this.btnAbrirSoma.Text = "Abrir Formulário de Soma";
            this.btnAbrirSoma.UseVisualStyleBackColor = true;
            this.btnAbrirSoma.Click += new System.EventHandler(this.btnAbrirSoma_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 193);
            this.Controls.Add(this.btnAbrirSoma);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnTrocarMensagem);
            this.Controls.Add(this.lblMensagem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambientação";
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnTrocarMensagem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAbrirSoma;
    }
}

