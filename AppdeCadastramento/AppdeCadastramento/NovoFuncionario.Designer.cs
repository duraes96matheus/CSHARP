namespace WindowsFormsApplication1
{
    partial class NovoFuncionario
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtfone = new System.Windows.Forms.MaskedTextBox();
            this.txtnascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtende = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 9);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(12, 35);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(52, 13);
            this.lbltelefone.TabIndex = 1;
            this.lbltelefone.Text = "Telefone:";
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(15, 61);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(66, 13);
            this.lblnascimento.TabIndex = 2;
            this.lblnascimento.Text = "Nascimento:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(15, 87);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "Email:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(16, 113);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 13);
            this.lblsexo.TabIndex = 4;
            this.lblsexo.Text = "Sexo:";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Location = new System.Drawing.Point(12, 139);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(38, 13);
            this.lblcargo.TabIndex = 5;
            this.lblcargo.Text = "Cargo:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(56, 6);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(288, 20);
            this.txtnome.TabIndex = 6;
            // 
            // txtfone
            // 
            this.txtfone.Location = new System.Drawing.Point(70, 32);
            this.txtfone.Mask = "(##) #####-####";
            this.txtfone.Name = "txtfone";
            this.txtfone.Size = new System.Drawing.Size(186, 20);
            this.txtfone.TabIndex = 7;
            // 
            // txtnascimento
            // 
            this.txtnascimento.Location = new System.Drawing.Point(87, 58);
            this.txtnascimento.Mask = "00/00/0000";
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(169, 20);
            this.txtnascimento.TabIndex = 8;
            this.txtnascimento.ValidatingType = typeof(System.DateTime);
      //     this.txtnascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtnascimento_MaskInputRejected);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(56, 84);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 20);
            this.txtemail.TabIndex = 9;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(56, 136);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(200, 20);
            this.txtcargo.TabIndex = 10;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(56, 110);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(200, 20);
            this.txtsexo.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 200);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(96, 200);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(16, 167);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(56, 13);
            this.lblendereco.TabIndex = 14;
            this.lblendereco.Text = "Endereço:";
            // 
            // txtende
            // 
            this.txtende.Location = new System.Drawing.Point(78, 162);
            this.txtende.Name = "txtende";
            this.txtende.Size = new System.Drawing.Size(178, 20);
            this.txtende.TabIndex = 15;
            // 
            // NovoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.txtende);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.txtfone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblnascimento);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lblnome);
            this.Name = "NovoFuncionario";
            this.Text = "Novo Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox txtfone;
        private System.Windows.Forms.MaskedTextBox txtnascimento;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtende;
    }
}