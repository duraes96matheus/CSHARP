namespace WindowsFormsApplication1
{
    partial class CadastrarClientes
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.TXTdatanascimento = new System.Windows.Forms.TextBox();
            this.BTNcadastrar = new System.Windows.Forms.Button();
            this.DGVclientecadastrado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientecadastrado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(131, 20);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Codigo Cliente:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Nascimento";
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.Location = new System.Drawing.Point(149, 11);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(100, 20);
            this.TXTCodigo.TabIndex = 3;
            // 
            // TXTnome
            // 
            this.TXTnome.Location = new System.Drawing.Point(78, 42);
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(233, 20);
            this.TXTnome.TabIndex = 4;
            // 
            // TXTdatanascimento
            // 
            this.TXTdatanascimento.Location = new System.Drawing.Point(165, 73);
            this.TXTdatanascimento.Name = "TXTdatanascimento";
            this.TXTdatanascimento.Size = new System.Drawing.Size(146, 20);
            this.TXTdatanascimento.TabIndex = 5;
            // 
            // BTNcadastrar
            // 
            this.BTNcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcadastrar.Location = new System.Drawing.Point(16, 122);
            this.BTNcadastrar.Name = "BTNcadastrar";
            this.BTNcadastrar.Size = new System.Drawing.Size(311, 58);
            this.BTNcadastrar.TabIndex = 6;
            this.BTNcadastrar.Text = "Cadastrar";
            this.BTNcadastrar.UseVisualStyleBackColor = true;
            this.BTNcadastrar.Click += new System.EventHandler(this.BTNcadastrar_Click);
            // 
            // DGVclientecadastrado
            // 
            this.DGVclientecadastrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclientecadastrado.Location = new System.Drawing.Point(333, 12);
            this.DGVclientecadastrado.Name = "DGVclientecadastrado";
            this.DGVclientecadastrado.Size = new System.Drawing.Size(435, 277);
            this.DGVclientecadastrado.TabIndex = 7;

            // 
            // CadastrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 350);
            this.Controls.Add(this.DGVclientecadastrado);
            this.Controls.Add(this.BTNcadastrar);
            this.Controls.Add(this.TXTdatanascimento);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.TXTCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigoCliente);
            this.Name = "CadastrarClientes";
            this.Text = "CadastrarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientecadastrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTCodigo;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.TextBox TXTdatanascimento;
        private System.Windows.Forms.Button BTNcadastrar;
        private System.Windows.Forms.DataGridView DGVclientecadastrado;
    }
}