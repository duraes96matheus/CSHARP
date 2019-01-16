namespace CalculadoraMedia
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbl1bim = new System.Windows.Forms.Label();
            this.lbl4bim = new System.Windows.Forms.Label();
            this.lbl3bim = new System.Windows.Forms.Label();
            this.lbl2bim = new System.Windows.Forms.Label();
            this.txt3Bim = new System.Windows.Forms.TextBox();
            this.txt2Bim = new System.Windows.Forms.TextBox();
            this.txt4Bim = new System.Windows.Forms.TextBox();
            this.txt1Bim = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(131, 194);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbl1bim
            // 
            this.lbl1bim.AutoSize = true;
            this.lbl1bim.Location = new System.Drawing.Point(12, 96);
            this.lbl1bim.Name = "lbl1bim";
            this.lbl1bim.Size = new System.Drawing.Size(34, 13);
            this.lbl1bim.TabIndex = 1;
            this.lbl1bim.Text = "1°Bim";
            // 
            // lbl4bim
            // 
            this.lbl4bim.AutoSize = true;
            this.lbl4bim.Location = new System.Drawing.Point(172, 149);
            this.lbl4bim.Name = "lbl4bim";
            this.lbl4bim.Size = new System.Drawing.Size(34, 13);
            this.lbl4bim.TabIndex = 2;
            this.lbl4bim.Text = "4°Bim";
            // 
            // lbl3bim
            // 
            this.lbl3bim.AutoSize = true;
            this.lbl3bim.Location = new System.Drawing.Point(172, 96);
            this.lbl3bim.Name = "lbl3bim";
            this.lbl3bim.Size = new System.Drawing.Size(34, 13);
            this.lbl3bim.TabIndex = 3;
            this.lbl3bim.Text = "3°Bim";
            // 
            // lbl2bim
            // 
            this.lbl2bim.AutoSize = true;
            this.lbl2bim.Location = new System.Drawing.Point(12, 149);
            this.lbl2bim.Name = "lbl2bim";
            this.lbl2bim.Size = new System.Drawing.Size(34, 13);
            this.lbl2bim.TabIndex = 4;
            this.lbl2bim.Text = "2°Bim";
            this.lbl2bim.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt3Bim
            // 
            this.txt3Bim.Location = new System.Drawing.Point(212, 96);
            this.txt3Bim.Name = "txt3Bim";
            this.txt3Bim.Size = new System.Drawing.Size(100, 20);
            this.txt3Bim.TabIndex = 5;
            // 
            // txt2Bim
            // 
            this.txt2Bim.Location = new System.Drawing.Point(53, 149);
            this.txt2Bim.Name = "txt2Bim";
            this.txt2Bim.Size = new System.Drawing.Size(100, 20);
            this.txt2Bim.TabIndex = 6;
            // 
            // txt4Bim
            // 
            this.txt4Bim.Location = new System.Drawing.Point(212, 146);
            this.txt4Bim.Name = "txt4Bim";
            this.txt4Bim.Size = new System.Drawing.Size(100, 20);
            this.txt4Bim.TabIndex = 7;
            // 
            // txt1Bim
            // 
            this.txt1Bim.Location = new System.Drawing.Point(53, 93);
            this.txt1Bim.Name = "txt1Bim";
            this.txt1Bim.Size = new System.Drawing.Size(100, 20);
            this.txt1Bim.TabIndex = 8;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(6, 23);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(79, 13);
            this.lblAluno.TabIndex = 9;
            this.lblAluno.Text = "Nome do aluno";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(211, 20);
            this.txtNome.TabIndex = 10;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(150, 250);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 13);
            this.lblMedia.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 335);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txt1Bim);
            this.Controls.Add(this.txt4Bim);
            this.Controls.Add(this.txt2Bim);
            this.Controls.Add(this.txt3Bim);
            this.Controls.Add(this.lbl2bim);
            this.Controls.Add(this.lbl3bim);
            this.Controls.Add(this.lbl4bim);
            this.Controls.Add(this.lbl1bim);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbl1bim;
        private System.Windows.Forms.Label lbl4bim;
        private System.Windows.Forms.Label lbl3bim;
        private System.Windows.Forms.Label lbl2bim;
        private System.Windows.Forms.TextBox txt3Bim;
        private System.Windows.Forms.TextBox txt2Bim;
        private System.Windows.Forms.TextBox txt4Bim;
        private System.Windows.Forms.TextBox txt1Bim;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMedia;
    }
}

