namespace WindowsFormsApplication1
{
    partial class NovoCliente
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnasci = new System.Windows.Forms.MaskedTextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblidfun = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 9);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome:";
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(12, 35);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(66, 13);
            this.lblnascimento.TabIndex = 2;
            this.lblnascimento.Text = "Nascimento:";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(12, 61);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(56, 13);
            this.lblendereco.TabIndex = 3;
            this.lblendereco.Text = "Endereço:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(56, 6);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(216, 20);
            this.txtnome.TabIndex = 4;
            // 
            // txtnasci
            // 
            this.txtnasci.Location = new System.Drawing.Point(84, 32);
            this.txtnasci.Mask = "00/00/0000";
            this.txtnasci.Name = "txtnasci";
            this.txtnasci.Size = new System.Drawing.Size(100, 20);
            this.txtnasci.TabIndex = 5;
            this.txtnasci.ValidatingType = typeof(System.DateTime);
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(74, 58);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(198, 20);
            this.txtendereco.TabIndex = 6;
            // 
            // lblidfun
            // 
            this.lblidfun.AutoSize = true;
            this.lblidfun.Location = new System.Drawing.Point(15, 93);
            this.lblidfun.Name = "lblidfun";
            this.lblidfun.Size = new System.Drawing.Size(79, 13);
            this.lblidfun.TabIndex = 7;
            this.lblidfun.Text = "ID Funcionário:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 90);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(172, 20);
            this.txtid.TabIndex = 8;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(19, 128);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(109, 128);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // NovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblidfun);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtnasci);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblnascimento);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.label1);
            this.Name = "NovoCliente";
            this.Text = "Novo Cliente";
            this.Load += new System.EventHandler(this.NovoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox txtnasci;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblidfun;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
    }
}