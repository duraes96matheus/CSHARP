namespace PrjCidadeInteligente
{
    partial class Cliente
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblIDPessoa = new System.Windows.Forms.Label();
            this.txidPessoa = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.DGVcliente = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblIDPessoa);
            this.gbCliente.Controls.Add(this.txidPessoa);
            this.gbCliente.Controls.Add(this.lblData);
            this.gbCliente.Controls.Add(this.txtData);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(276, 114);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Dados do Cliente";
            // 
            // lblIDPessoa
            // 
            this.lblIDPessoa.AutoSize = true;
            this.lblIDPessoa.Location = new System.Drawing.Point(6, 62);
            this.lblIDPessoa.Name = "lblIDPessoa";
            this.lblIDPessoa.Size = new System.Drawing.Size(56, 13);
            this.lblIDPessoa.TabIndex = 6;
            this.lblIDPessoa.Text = "ID Pessoa";
            // 
            // txidPessoa
            // 
            this.txidPessoa.Location = new System.Drawing.Point(103, 59);
            this.txidPessoa.Name = "txidPessoa";
            this.txidPessoa.Size = new System.Drawing.Size(100, 20);
            this.txidPessoa.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(6, 36);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(91, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data da Inclusão:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(103, 33);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 2;
            // 
            // DGVcliente
            // 
            this.DGVcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcliente.Location = new System.Drawing.Point(294, 11);
            this.DGVcliente.Name = "DGVcliente";
            this.DGVcliente.Size = new System.Drawing.Size(318, 195);
            this.DGVcliente.TabIndex = 1;          
            this.DGVcliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcliente_CellDoubleClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 132);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
         
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(93, 132);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 210);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.DGVcliente);
            this.Controls.Add(this.gbCliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridView DGVcliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblIDPessoa;
        private System.Windows.Forms.TextBox txidPessoa;

    }
}