namespace Calculo_de_Salario
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
            this.ckbClt = new System.Windows.Forms.CheckBox();
            this.ckbComissionado = new System.Windows.Forms.CheckBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.ckbEstagario = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbHoras = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbClt
            // 
            this.ckbClt.AutoSize = true;
            this.ckbClt.Location = new System.Drawing.Point(12, 46);
            this.ckbClt.Name = "ckbClt";
            this.ckbClt.Size = new System.Drawing.Size(46, 17);
            this.ckbClt.TabIndex = 0;
            this.ckbClt.Text = "CLT";
            this.ckbClt.UseVisualStyleBackColor = true;
            this.ckbClt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbComissionado
            // 
            this.ckbComissionado.AutoSize = true;
            this.ckbComissionado.Location = new System.Drawing.Point(81, 46);
            this.ckbComissionado.Name = "ckbComissionado";
            this.ckbComissionado.Size = new System.Drawing.Size(91, 17);
            this.ckbComissionado.TabIndex = 1;
            this.ckbComissionado.Text = "Comissionado";
            this.ckbComissionado.UseVisualStyleBackColor = true;
            this.ckbComissionado.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome :";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(59, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(211, 20);
            this.txbNome.TabIndex = 3;
            // 
            // ckbEstagario
            // 
            this.ckbEstagario.AutoSize = true;
            this.ckbEstagario.Location = new System.Drawing.Point(195, 46);
            this.ckbEstagario.Name = "ckbEstagario";
            this.ckbEstagario.Size = new System.Drawing.Size(72, 17);
            this.ckbEstagario.TabIndex = 4;
            this.ckbEstagario.Text = "Estagiário";
            this.ckbEstagario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total de horas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor das horas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 7;
            // 
            // txbHoras
            // 
            this.txbHoras.Location = new System.Drawing.Point(93, 87);
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(177, 20);
            this.txbHoras.TabIndex = 8;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(93, 123);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(177, 20);
            this.txbValor.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.txbHoras);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbEstagario);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ckbComissionado);
            this.Controls.Add(this.ckbClt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbClt;
        private System.Windows.Forms.CheckBox ckbComissionado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.CheckBox ckbEstagario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txbHoras;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

