namespace AppAmbientacao
{
    partial class frmSomaNumeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor1:";
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(16, 33);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(386, 22);
            this.txtPrimeiroValor.TabIndex = 1;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(16, 91);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(386, 22);
            this.txtSegundoValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor2:";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(16, 146);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(386, 23);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Soma&r";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(16, 200);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 16);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "0";
            // 
            // frmSomaNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 237);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.label1);
            this.Name = "frmSomaNumeros";
            this.Text = "Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblResultado;
    }
}