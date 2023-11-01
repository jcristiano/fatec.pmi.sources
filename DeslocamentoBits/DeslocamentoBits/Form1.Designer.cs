namespace DeslocamentoBits
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
            this.txtPrimeiro = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.gpbOperadores = new System.Windows.Forms.GroupBox();
            this.rbtDescolamentoEsquerda = new System.Windows.Forms.RadioButton();
            this.rbtOperadorXOR = new System.Windows.Forms.RadioButton();
            this.rbtOperadorOR = new System.Windows.Forms.RadioButton();
            this.rbtOperadorE = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbtDescolamentoDireita = new System.Windows.Forms.RadioButton();
            this.gpbOperadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrimeiro
            // 
            this.txtPrimeiro.Location = new System.Drawing.Point(12, 28);
            this.txtPrimeiro.Name = "txtPrimeiro";
            this.txtPrimeiro.Size = new System.Drawing.Size(586, 22);
            this.txtPrimeiro.TabIndex = 0;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(12, 99);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(586, 22);
            this.txtSegundo.TabIndex = 1;
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(12, 9);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(57, 16);
            this.lblPrimeiro.TabIndex = 2;
            this.lblPrimeiro.Text = "Primeiro";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(15, 80);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(62, 16);
            this.lblSegundo.TabIndex = 3;
            this.lblSegundo.Text = "Segundo";
            // 
            // gpbOperadores
            // 
            this.gpbOperadores.Controls.Add(this.rbtDescolamentoDireita);
            this.gpbOperadores.Controls.Add(this.rbtDescolamentoEsquerda);
            this.gpbOperadores.Controls.Add(this.rbtOperadorXOR);
            this.gpbOperadores.Controls.Add(this.rbtOperadorOR);
            this.gpbOperadores.Controls.Add(this.rbtOperadorE);
            this.gpbOperadores.Location = new System.Drawing.Point(15, 147);
            this.gpbOperadores.Name = "gpbOperadores";
            this.gpbOperadores.Size = new System.Drawing.Size(583, 174);
            this.gpbOperadores.TabIndex = 4;
            this.gpbOperadores.TabStop = false;
            this.gpbOperadores.Text = "Operadores";
            // 
            // rbtDescolamentoEsquerda
            // 
            this.rbtDescolamentoEsquerda.AutoSize = true;
            this.rbtDescolamentoEsquerda.Location = new System.Drawing.Point(187, 94);
            this.rbtDescolamentoEsquerda.Name = "rbtDescolamentoEsquerda";
            this.rbtDescolamentoEsquerda.Size = new System.Drawing.Size(156, 20);
            this.rbtDescolamentoEsquerda.TabIndex = 3;
            this.rbtDescolamentoEsquerda.Tag = "LEFT";
            this.rbtDescolamentoEsquerda.Text = "Deslocar a Esquerda";
            this.rbtDescolamentoEsquerda.UseVisualStyleBackColor = true;
            this.rbtDescolamentoEsquerda.Click += new System.EventHandler(this.rbtDescolamentoEsquerda_Click);
            // 
            // rbtOperadorXOR
            // 
            this.rbtOperadorXOR.AutoSize = true;
            this.rbtOperadorXOR.Location = new System.Drawing.Point(187, 41);
            this.rbtOperadorXOR.Name = "rbtOperadorXOR";
            this.rbtOperadorXOR.Size = new System.Drawing.Size(117, 20);
            this.rbtOperadorXOR.TabIndex = 2;
            this.rbtOperadorXOR.Tag = "XOR";
            this.rbtOperadorXOR.Text = "Operador XOR";
            this.rbtOperadorXOR.UseVisualStyleBackColor = true;
            // 
            // rbtOperadorOR
            // 
            this.rbtOperadorOR.AutoSize = true;
            this.rbtOperadorOR.Location = new System.Drawing.Point(27, 94);
            this.rbtOperadorOR.Name = "rbtOperadorOR";
            this.rbtOperadorOR.Size = new System.Drawing.Size(109, 20);
            this.rbtOperadorOR.TabIndex = 1;
            this.rbtOperadorOR.Tag = "OR";
            this.rbtOperadorOR.Text = "Operador OR";
            this.rbtOperadorOR.UseVisualStyleBackColor = true;
            // 
            // rbtOperadorE
            // 
            this.rbtOperadorE.AutoSize = true;
            this.rbtOperadorE.Checked = true;
            this.rbtOperadorE.Location = new System.Drawing.Point(27, 41);
            this.rbtOperadorE.Name = "rbtOperadorE";
            this.rbtOperadorE.Size = new System.Drawing.Size(98, 20);
            this.rbtOperadorE.TabIndex = 0;
            this.rbtOperadorE.TabStop = true;
            this.rbtOperadorE.Tag = "E";
            this.rbtOperadorE.Text = "Operador E";
            this.rbtOperadorE.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(583, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Executa&r";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 421);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(11, 16);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "-";
            this.lblResultado.TextChanged += new System.EventHandler(this.lblResultado_TextChanged);
            // 
            // rbtDescolamentoDireita
            // 
            this.rbtDescolamentoDireita.AutoSize = true;
            this.rbtDescolamentoDireita.Location = new System.Drawing.Point(368, 41);
            this.rbtDescolamentoDireita.Name = "rbtDescolamentoDireita";
            this.rbtDescolamentoDireita.Size = new System.Drawing.Size(136, 20);
            this.rbtDescolamentoDireita.TabIndex = 4;
            this.rbtDescolamentoDireita.Tag = "RIGHT";
            this.rbtDescolamentoDireita.Text = "Deslocar a Direita";
            this.rbtDescolamentoDireita.UseVisualStyleBackColor = true;
            this.rbtDescolamentoDireita.CheckedChanged += new System.EventHandler(this.rbtDescolamentoDireita_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 475);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbOperadores);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtPrimeiro);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbOperadores.ResumeLayout(false);
            this.gpbOperadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimeiro;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.GroupBox gpbOperadores;
        private System.Windows.Forms.RadioButton rbtOperadorXOR;
        private System.Windows.Forms.RadioButton rbtOperadorOR;
        private System.Windows.Forms.RadioButton rbtOperadorE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbtDescolamentoEsquerda;
        private System.Windows.Forms.RadioButton rbtDescolamentoDireita;
    }
}

