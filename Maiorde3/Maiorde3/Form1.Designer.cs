namespace Maiorde3
{
    partial class Form1
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbValor2 = new System.Windows.Forms.TextBox();
            this.txbValor1 = new System.Windows.Forms.TextBox();
            this.txbValor3 = new System.Windows.Forms.TextBox();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.lblValorC = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(89, 206);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(64, 22);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txbValor2
            // 
            this.txbValor2.Location = new System.Drawing.Point(53, 78);
            this.txbValor2.Name = "txbValor2";
            this.txbValor2.Size = new System.Drawing.Size(100, 20);
            this.txbValor2.TabIndex = 1;
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new System.Drawing.Point(53, 32);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new System.Drawing.Size(100, 20);
            this.txbValor1.TabIndex = 2;
            // 
            // txbValor3
            // 
            this.txbValor3.Location = new System.Drawing.Point(53, 123);
            this.txbValor3.Name = "txbValor3";
            this.txbValor3.Size = new System.Drawing.Size(100, 20);
            this.txbValor3.TabIndex = 3;
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(12, 32);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(41, 13);
            this.lblValorA.TabIndex = 4;
            this.lblValorA.Text = "Valor A";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(12, 81);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(41, 13);
            this.lblValorB.TabIndex = 5;
            this.lblValorB.Text = "Valor B";
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.Location = new System.Drawing.Point(12, 123);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(41, 13);
            this.lblValorC.TabIndex = 6;
            this.lblValorC.Text = "Valor C";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(86, 169);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Controls.Add(this.txbValor3);
            this.Controls.Add(this.txbValor1);
            this.Controls.Add(this.txbValor2);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txbValor2;
        private System.Windows.Forms.TextBox txbValor1;
        private System.Windows.Forms.TextBox txbValor3;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.Label lblResposta;
    }
}

