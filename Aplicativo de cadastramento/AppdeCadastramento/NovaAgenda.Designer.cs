namespace WindowsFormsApplication1
{
    partial class NovaAgenda
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
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblfuncionario = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidfun = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txtnomemedico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(12, 9);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(56, 13);
            this.lblidcliente.TabIndex = 0;
            this.lblidcliente.Text = "ID Cliente:";
            // 
            // lblfuncionario
            // 
            this.lblfuncionario.AutoSize = true;
            this.lblfuncionario.Location = new System.Drawing.Point(12, 33);
            this.lblfuncionario.Name = "lblfuncionario";
            this.lblfuncionario.Size = new System.Drawing.Size(76, 13);
            this.lblfuncionario.TabIndex = 1;
            this.lblfuncionario.Text = "ID Funcionario";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(12, 63);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(33, 13);
            this.lbldata.TabIndex = 2;
            this.lbldata.Text = "Data:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(0, 88);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(45, 13);
            this.lblMedico.TabIndex = 3;
            this.lblMedico.Text = "Médico:";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(94, 4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(177, 20);
            this.txtidcliente.TabIndex = 4;
            // 
            // txtidfun
            // 
            this.txtidfun.Location = new System.Drawing.Point(94, 30);
            this.txtidfun.Name = "txtidfun";
            this.txtidfun.Size = new System.Drawing.Size(177, 20);
            this.txtidfun.TabIndex = 5;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(51, 60);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(220, 20);
            this.txtdata.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 128);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
           
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(94, 128);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 11;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // txtnomemedico
            // 
            this.txtnomemedico.Location = new System.Drawing.Point(51, 88);
            this.txtnomemedico.Name = "txtnomemedico";
            this.txtnomemedico.Size = new System.Drawing.Size(220, 20);
            this.txtnomemedico.TabIndex = 12;
            // 
            // NovaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtnomemedico);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtidfun);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblfuncionario);
            this.Controls.Add(this.lblidcliente);
            this.Name = "NovaAgenda";
            this.RightToLeftLayout = true;
            this.Text = "Nova Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblfuncionario;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtidfun;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txtnomemedico;
    }
}