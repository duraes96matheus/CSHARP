namespace PrjCidadeInteligente
{
    partial class PessoaDocumento
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
            this.gbDocumentoPessoa = new System.Windows.Forms.GroupBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblReser = new System.Windows.Forms.Label();
            this.lblCarteira = new System.Windows.Forms.Label();
            this.lblCnh = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.txtReser = new System.Windows.Forms.TextBox();
            this.txtCarteira = new System.Windows.Forms.TextBox();
            this.gbDocumentoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDocumentoPessoa
            // 
            this.gbDocumentoPessoa.Controls.Add(this.txtCarteira);
            this.gbDocumentoPessoa.Controls.Add(this.txtReser);
            this.gbDocumentoPessoa.Controls.Add(this.txtCnh);
            this.gbDocumentoPessoa.Controls.Add(this.txtCpf);
            this.gbDocumentoPessoa.Controls.Add(this.txtRg);
            this.gbDocumentoPessoa.Controls.Add(this.lblCnh);
            this.gbDocumentoPessoa.Controls.Add(this.lblCarteira);
            this.gbDocumentoPessoa.Controls.Add(this.lblReser);
            this.gbDocumentoPessoa.Controls.Add(this.lblCpf);
            this.gbDocumentoPessoa.Controls.Add(this.lblRg);
            this.gbDocumentoPessoa.Location = new System.Drawing.Point(11, 17);
            this.gbDocumentoPessoa.Name = "gbDocumentoPessoa";
            this.gbDocumentoPessoa.Size = new System.Drawing.Size(507, 177);
            this.gbDocumentoPessoa.TabIndex = 0;
            this.gbDocumentoPessoa.TabStop = false;
            this.gbDocumentoPessoa.Text = "Documento da Pessoa";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(46, 35);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(26, 13);
            this.lblRg.TabIndex = 1;
            this.lblRg.Text = "RG:";
            this.lblRg.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(262, 35);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // lblReser
            // 
            this.lblReser.AutoSize = true;
            this.lblReser.Location = new System.Drawing.Point(262, 127);
            this.lblReser.Name = "lblReser";
            this.lblReser.Size = new System.Drawing.Size(57, 13);
            this.lblReser.TabIndex = 3;
            this.lblReser.Text = "Reservista";
            // 
            // lblCarteira
            // 
            this.lblCarteira.AutoSize = true;
            this.lblCarteira.Location = new System.Drawing.Point(46, 76);
            this.lblCarteira.Name = "lblCarteira";
            this.lblCarteira.Size = new System.Drawing.Size(106, 13);
            this.lblCarteira.TabIndex = 4;
            this.lblCarteira.Text = "Carteira de Trabalho:";
            // 
            // lblCnh
            // 
            this.lblCnh.AutoSize = true;
            this.lblCnh.Location = new System.Drawing.Point(46, 120);
            this.lblCnh.Name = "lblCnh";
            this.lblCnh.Size = new System.Drawing.Size(33, 13);
            this.lblCnh.TabIndex = 5;
            this.lblCnh.Text = "CNH:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(87, 28);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(154, 20);
            this.txtRg.TabIndex = 6;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(309, 28);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(163, 20);
            this.txtCpf.TabIndex = 7;
            // 
            // txtCnh
            // 
            this.txtCnh.Location = new System.Drawing.Point(85, 120);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(154, 20);
            this.txtCnh.TabIndex = 8;
            // 
            // txtReser
            // 
            this.txtReser.Location = new System.Drawing.Point(325, 127);
            this.txtReser.Name = "txtReser";
            this.txtReser.Size = new System.Drawing.Size(147, 20);
            this.txtReser.TabIndex = 9;
            // 
            // txtCarteira
            // 
            this.txtCarteira.Location = new System.Drawing.Point(158, 76);
            this.txtCarteira.Name = "txtCarteira";
            this.txtCarteira.Size = new System.Drawing.Size(314, 20);
            this.txtCarteira.TabIndex = 10;
            // 
            // PessoaDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 218);
            this.Controls.Add(this.gbDocumentoPessoa);
            this.Name = "PessoaDocumento";
            this.Text = "PessoaDocumento";
            this.gbDocumentoPessoa.ResumeLayout(false);
            this.gbDocumentoPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDocumentoPessoa;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblCnh;
        private System.Windows.Forms.Label lblCarteira;
        private System.Windows.Forms.Label lblReser;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCarteira;
        private System.Windows.Forms.TextBox txtReser;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.TextBox txtCpf;
    }
}