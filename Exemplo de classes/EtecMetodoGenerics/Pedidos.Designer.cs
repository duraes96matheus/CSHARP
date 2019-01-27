namespace EtecMetodoGenerics
{
    partial class Pedidos
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
            this.components = new System.ComponentModel.Container();
            this.gdvPedidos = new System.Windows.Forms.DataGridView();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblMarcaNova = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtpreço = new System.Windows.Forms.TextBox();
            this.txtmarcaNova = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblresposta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvPedidos
            // 
            this.gdvPedidos.AutoGenerateColumns = false;
            this.gdvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.nmProdutoDataGridViewTextBoxColumn,
            this.dtPedidoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn});
            this.gdvPedidos.DataSource = this.clientePedidoBindingSource;
            this.gdvPedidos.Location = new System.Drawing.Point(22, 42);
            this.gdvPedidos.Name = "gdvPedidos";
            this.gdvPedidos.Size = new System.Drawing.Size(545, 195);
            this.gdvPedidos.TabIndex = 0;
         
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            // 
            // nmProdutoDataGridViewTextBoxColumn
            // 
            this.nmProdutoDataGridViewTextBoxColumn.DataPropertyName = "nmProduto";
            this.nmProdutoDataGridViewTextBoxColumn.HeaderText = "nmProduto";
            this.nmProdutoDataGridViewTextBoxColumn.Name = "nmProdutoDataGridViewTextBoxColumn";
            // 
            // dtPedidoDataGridViewTextBoxColumn
            // 
            this.dtPedidoDataGridViewTextBoxColumn.DataPropertyName = "dtPedido";
            this.dtPedidoDataGridViewTextBoxColumn.HeaderText = "dtPedido";
            this.dtPedidoDataGridViewTextBoxColumn.Name = "dtPedidoDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // clientePedidoBindingSource
            // 
            this.clientePedidoBindingSource.DataSource = typeof(Classes.ClientePedido);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(158, 257);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(328, 20);
            this.txtPesquisar.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(492, 255);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(101, 288);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(158, 288);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(328, 20);
            this.txtmarca.TabIndex = 5;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(492, 286);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(610, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(607, 114);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(81, 13);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data do Pedido";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(609, 153);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(613, 255);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblMarcaNova
            // 
            this.lblMarcaNova.AutoSize = true;
            this.lblMarcaNova.Location = new System.Drawing.Point(607, 201);
            this.lblMarcaNova.Name = "lblMarcaNova";
            this.lblMarcaNova.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaNova.TabIndex = 11;
            this.lblMarcaNova.Text = "Marca";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(610, 91);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(245, 20);
            this.txtnome.TabIndex = 12;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(608, 130);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(247, 20);
            this.txtData.TabIndex = 13;
            // 
            // txtpreço
            // 
            this.txtpreço.Location = new System.Drawing.Point(610, 178);
            this.txtpreço.Name = "txtpreço";
            this.txtpreço.Size = new System.Drawing.Size(245, 20);
            this.txtpreço.TabIndex = 14;
            // 
            // txtmarcaNova
            // 
            this.txtmarcaNova.Location = new System.Drawing.Point(610, 217);
            this.txtmarcaNova.Name = "txtmarcaNova";
            this.txtmarcaNova.Size = new System.Drawing.Size(245, 20);
            this.txtmarcaNova.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adição de Novos Produtos";
            // 
            // lblresposta
            // 
            this.lblresposta.AutoSize = true;
            this.lblresposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresposta.Location = new System.Drawing.Point(694, 260);
            this.lblresposta.Name = "lblresposta";
            this.lblresposta.Size = new System.Drawing.Size(0, 16);
            this.lblresposta.TabIndex = 17;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 332);
            this.Controls.Add(this.lblresposta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmarcaNova);
            this.Controls.Add(this.txtpreço);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblMarcaNova);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdvPedidos);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientePedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientePedidoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblMarcaNova;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtpreço;
        private System.Windows.Forms.TextBox txtmarcaNova;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblresposta;
    }
}