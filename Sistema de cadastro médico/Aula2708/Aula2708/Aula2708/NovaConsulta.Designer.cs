namespace Aula2708
{
    partial class NovaConsulta
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
            this.lblIdcliente = new System.Windows.Forms.Label();
            this.lblIdFuncionario = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblnmMedico = new System.Windows.Forms.Label();
            this.lblEspecia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdcliente
            // 
            this.lblIdcliente.AutoSize = true;
            this.lblIdcliente.Location = new System.Drawing.Point(13, 13);
            this.lblIdcliente.Name = "lblIdcliente";
            this.lblIdcliente.Size = new System.Drawing.Size(54, 13);
            this.lblIdcliente.TabIndex = 0;
            this.lblIdcliente.Text = "Id Cliente:";
            // 
            // lblIdFuncionario
            // 
            this.lblIdFuncionario.AutoSize = true;
            this.lblIdFuncionario.Location = new System.Drawing.Point(12, 45);
            this.lblIdFuncionario.Name = "lblIdFuncionario";
            this.lblIdFuncionario.Size = new System.Drawing.Size(77, 13);
            this.lblIdFuncionario.TabIndex = 1;
            this.lblIdFuncionario.Text = "Id Funcionario:";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(11, 74);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(92, 13);
            this.lblConsulta.TabIndex = 2;
            this.lblConsulta.Text = "Data da Consulta:";
            // 
            // lblnmMedico
            // 
            this.lblnmMedico.AutoSize = true;
            this.lblnmMedico.Location = new System.Drawing.Point(11, 103);
            this.lblnmMedico.Name = "lblnmMedico";
            this.lblnmMedico.Size = new System.Drawing.Size(91, 13);
            this.lblnmMedico.TabIndex = 3;
            this.lblnmMedico.Text = "Nome do Medico:";
            // 
            // lblEspecia
            // 
            this.lblEspecia.AutoSize = true;
            this.lblEspecia.Location = new System.Drawing.Point(12, 136);
            this.lblEspecia.Name = "lblEspecia";
            this.lblEspecia.Size = new System.Drawing.Size(73, 13);
            this.lblEspecia.TabIndex = 4;
            this.lblEspecia.Text = "Especialidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(28, 191);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(143, 190);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // NovaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEspecia);
            this.Controls.Add(this.lblnmMedico);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblIdFuncionario);
            this.Controls.Add(this.lblIdcliente);
            this.Name = "NovaConsulta";
            this.Text = "Nova Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdcliente;
        private System.Windows.Forms.Label lblIdFuncionario;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label lblnmMedico;
        private System.Windows.Forms.Label lblEspecia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}