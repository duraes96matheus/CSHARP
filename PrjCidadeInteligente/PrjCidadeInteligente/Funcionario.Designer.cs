namespace PrjCidadeInteligente
{
    partial class Funcionario
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
            this.gpFuncionario = new System.Windows.Forms.GroupBox();
            this.txtRamal = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.DGVFuncionario = new System.Windows.Forms.DataGridView();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.gpFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFuncionario
            // 
            this.gpFuncionario.Controls.Add(this.txtRamal);
            this.gpFuncionario.Controls.Add(this.txtSalario);
            this.gpFuncionario.Controls.Add(this.txtCargo);
            this.gpFuncionario.Controls.Add(this.label3);
            this.gpFuncionario.Controls.Add(this.lblSalario);
            this.gpFuncionario.Controls.Add(this.lblCargo);
            this.gpFuncionario.Location = new System.Drawing.Point(12, 12);
            this.gpFuncionario.Name = "gpFuncionario";
            this.gpFuncionario.Size = new System.Drawing.Size(239, 175);
            this.gpFuncionario.TabIndex = 0;
            this.gpFuncionario.TabStop = false;
            this.gpFuncionario.Text = "Dados do Funcionário";
            // 
            // txtRamal
            // 
            this.txtRamal.Location = new System.Drawing.Point(6, 125);
            this.txtRamal.Name = "txtRamal";
            this.txtRamal.Size = new System.Drawing.Size(192, 20);
            this.txtRamal.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(6, 86);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(192, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(6, 47);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(192, 20);
            this.txtCargo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ramal Empresarial:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(6, 70);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(17, 31);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo:";
            // 
            // DGVFuncionario
            // 
            this.DGVFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFuncionario.Location = new System.Drawing.Point(257, 12);
            this.DGVFuncionario.Name = "DGVFuncionario";
            this.DGVFuncionario.Size = new System.Drawing.Size(362, 199);
            this.DGVFuncionario.TabIndex = 1;
            this.DGVFuncionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFuncionario_CellContentDoubleClick);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(18, 193);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 2;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(99, 193);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(554, 229);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 5;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(326, 231);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(222, 20);
            this.txtPesquisar.TabIndex = 6;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 297);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.DGVFuncionario);
            this.Controls.Add(this.gpFuncionario);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.gpFuncionario.ResumeLayout(false);
            this.gpFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtRamal;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.DataGridView DGVFuncionario;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}