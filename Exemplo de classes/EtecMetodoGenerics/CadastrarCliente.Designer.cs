namespace EtecMetodoGenerics
{
    partial class CadastrarCliente
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
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbldtnas = new System.Windows.Forms.Label();
            this.txtpesquisarnome = new System.Windows.Forms.TextBox();
            this.txtdatacliente = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.DGVcliente = new System.Windows.Forms.DataGridView();
            this.txtlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(38, 40);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(99, 16);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Código Cliente:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(45, 68);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(92, 16);
            this.lblNomeCliente.TabIndex = 1;
            this.lblNomeCliente.Text = "Nome Cliente:";
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNascimento.Location = new System.Drawing.Point(12, 93);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(131, 16);
            this.lblDtNascimento.TabIndex = 2;
            this.lblDtNascimento.Text = "Data de Nascimento";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(143, 34);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoCliente.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(140, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtNasc
            // 
            this.txtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNasc.Location = new System.Drawing.Point(140, 90);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(200, 22);
            this.txtNasc.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 170);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 32);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(50, 233);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 8;
            this.lblnome.Text = "Nome:";
            // 
            // lbldtnas
            // 
            this.lbldtnas.AutoSize = true;
            this.lbldtnas.Location = new System.Drawing.Point(12, 258);
            this.lbldtnas.Name = "lbldtnas";
            this.lbldtnas.Size = new System.Drawing.Size(76, 13);
            this.lbldtnas.TabIndex = 9;
            this.lbldtnas.Text = "Data de Nasc:";
            // 
            // txtpesquisarnome
            // 
            this.txtpesquisarnome.Location = new System.Drawing.Point(94, 230);
            this.txtpesquisarnome.Name = "txtpesquisarnome";
            this.txtpesquisarnome.Size = new System.Drawing.Size(246, 20);
            this.txtpesquisarnome.TabIndex = 10;
            // 
            // txtdatacliente
            // 
            this.txtdatacliente.Location = new System.Drawing.Point(94, 255);
            this.txtdatacliente.Name = "txtdatacliente";
            this.txtdatacliente.Size = new System.Drawing.Size(246, 20);
            this.txtdatacliente.TabIndex = 11;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(15, 276);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 12;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(72, 119);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 16);
            this.lblTelefone.TabIndex = 13;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(140, 118);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(200, 20);
            this.txtFone.TabIndex = 14;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(67, 146);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 16);
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(140, 142);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(200, 20);
            this.txtendereco.TabIndex = 16;
            // 
            // DGVcliente
            // 
            this.DGVcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcliente.Location = new System.Drawing.Point(387, 22);
            this.DGVcliente.Name = "DGVcliente";
            this.DGVcliente.Size = new System.Drawing.Size(482, 224);
            this.DGVcliente.TabIndex = 7;
            // 
            // txtlimpar
            // 
            this.txtlimpar.Location = new System.Drawing.Point(265, 179);
            this.txtlimpar.Name = "txtlimpar";
            this.txtlimpar.Size = new System.Drawing.Size(75, 23);
            this.txtlimpar.TabIndex = 17;
            this.txtlimpar.Text = "Limpar";
            this.txtlimpar.UseVisualStyleBackColor = true;
            this.txtlimpar.Click += new System.EventHandler(this.txtlimpar_Click);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 311);
            this.Controls.Add(this.txtlimpar);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtdatacliente);
            this.Controls.Add(this.txtpesquisarnome);
            this.Controls.Add(this.lbldtnas);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.DGVcliente);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.lblDtNascimento);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Name = "CadastrarCliente";
            this.Text = "CadastrarCliente";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbldtnas;
        private System.Windows.Forms.TextBox txtpesquisarnome;
        private System.Windows.Forms.TextBox txtdatacliente;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.DataGridView DGVcliente;
        private System.Windows.Forms.Button txtlimpar;
    }
}