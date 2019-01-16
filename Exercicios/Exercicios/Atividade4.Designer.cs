namespace Exercicios
{
    partial class Atividade4
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
            this.btnverificar = new System.Windows.Forms.Button();
            this.lblpergunta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblresposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(15, 82);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(149, 23);
            this.btnverificar.TabIndex = 0;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // lblpergunta
            // 
            this.lblpergunta.AutoSize = true;
            this.lblpergunta.Location = new System.Drawing.Point(12, 27);
            this.lblpergunta.Name = "lblpergunta";
            this.lblpergunta.Size = new System.Drawing.Size(27, 13);
            this.lblpergunta.TabIndex = 1;
            this.lblpergunta.Text = "Mês";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblresposta
            // 
            this.lblresposta.AutoSize = true;
            this.lblresposta.Location = new System.Drawing.Point(12, 124);
            this.lblresposta.Name = "lblresposta";
            this.lblresposta.Size = new System.Drawing.Size(55, 13);
            this.lblresposta.TabIndex = 3;
            this.lblresposta.Text = "Resposta:";
            // 
            // Atividade4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 165);
            this.Controls.Add(this.lblresposta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblpergunta);
            this.Controls.Add(this.btnverificar);
            this.Name = "Atividade4";
            this.Text = "Atividade4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atividade4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label lblpergunta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblresposta;
    }
}