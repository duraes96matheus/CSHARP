namespace PrjCliente_conexao
{
    partial class Form1
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblValormatricula = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.dtp_nasc = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtnascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsenderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsnumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD__ClienteDataSet = new PrjCliente_conexao.BD__ClienteDataSet();
            this.tB_clienteTableAdapter = new PrjCliente_conexao.BD__ClienteDataSetTableAdapters.TB_clienteTableAdapter();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD__ClienteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(12, 9);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula\r\n";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(12, 66);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(12, 95);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(53, 13);
            this.lblendereco.TabIndex = 3;
            this.lblendereco.Text = "Endereço";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 125);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número";
            // 
            // lblValormatricula
            // 
            this.lblValormatricula.AutoSize = true;
            this.lblValormatricula.Location = new System.Drawing.Point(68, 9);
            this.lblValormatricula.Name = "lblValormatricula";
            this.lblValormatricula.Size = new System.Drawing.Size(19, 13);
            this.lblValormatricula.TabIndex = 5;
            this.lblValormatricula.Text = "40";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(81, 32);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(318, 20);
            this.txt_Nome.TabIndex = 6;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // dtp_nasc
            // 
            this.dtp_nasc.Location = new System.Drawing.Point(81, 58);
            this.dtp_nasc.Name = "dtp_nasc";
            this.dtp_nasc.Size = new System.Drawing.Size(145, 20);
            this.dtp_nasc.TabIndex = 7;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(81, 125);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(101, 20);
            this.txt_numero.TabIndex = 9;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(227, 128);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 10;
            this.lblCep.Text = "CEP";
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(15, 180);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 12;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(96, 180);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(177, 180);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(258, 180);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(75, 23);
            this.btnultimo.TabIndex = 15;
            this.btnultimo.Text = "Último";
            this.btnultimo.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(466, 35);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(466, 60);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(466, 89);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(466, 120);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.dsnomeDataGridViewTextBoxColumn,
            this.dtnascimentoDataGridViewTextBoxColumn,
            this.dsenderecoDataGridViewTextBoxColumn,
            this.dsnumeroDataGridViewTextBoxColumn,
            this.dsCepDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBclienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 219);
            this.dataGridView1.TabIndex = 20;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // dsnomeDataGridViewTextBoxColumn
            // 
            this.dsnomeDataGridViewTextBoxColumn.DataPropertyName = "ds_nome";
            this.dsnomeDataGridViewTextBoxColumn.HeaderText = "ds_nome";
            this.dsnomeDataGridViewTextBoxColumn.Name = "dsnomeDataGridViewTextBoxColumn";
            // 
            // dtnascimentoDataGridViewTextBoxColumn
            // 
            this.dtnascimentoDataGridViewTextBoxColumn.DataPropertyName = "dt_nascimento";
            this.dtnascimentoDataGridViewTextBoxColumn.HeaderText = "dt_nascimento";
            this.dtnascimentoDataGridViewTextBoxColumn.Name = "dtnascimentoDataGridViewTextBoxColumn";
            // 
            // dsenderecoDataGridViewTextBoxColumn
            // 
            this.dsenderecoDataGridViewTextBoxColumn.DataPropertyName = "ds_endereco";
            this.dsenderecoDataGridViewTextBoxColumn.HeaderText = "ds_endereco";
            this.dsenderecoDataGridViewTextBoxColumn.Name = "dsenderecoDataGridViewTextBoxColumn";
            // 
            // dsnumeroDataGridViewTextBoxColumn
            // 
            this.dsnumeroDataGridViewTextBoxColumn.DataPropertyName = "ds_numero";
            this.dsnumeroDataGridViewTextBoxColumn.HeaderText = "ds_numero";
            this.dsnumeroDataGridViewTextBoxColumn.Name = "dsnumeroDataGridViewTextBoxColumn";
            // 
            // dsCepDataGridViewTextBoxColumn
            // 
            this.dsCepDataGridViewTextBoxColumn.DataPropertyName = "ds_Cep";
            this.dsCepDataGridViewTextBoxColumn.HeaderText = "ds_Cep";
            this.dsCepDataGridViewTextBoxColumn.Name = "dsCepDataGridViewTextBoxColumn";
            // 
            // tBclienteBindingSource
            // 
            this.tBclienteBindingSource.DataMember = "TB_cliente";
            this.tBclienteBindingSource.DataSource = this.bD__ClienteDataSet;
            // 
            // bD__ClienteDataSet
            // 
            this.bD__ClienteDataSet.DataSetName = "BD__ClienteDataSet";
            this.bD__ClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_clienteTableAdapter
            // 
            this.tB_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Location = new System.Drawing.Point(121, 455);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(313, 20);
            this.txt_Pesquisar.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pesquisar por nome: ";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(81, 92);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(318, 20);
            this.txt_endereco.TabIndex = 8;
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(261, 125);
            this.msk_cep.Mask = "00000-000";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(138, 20);
            this.msk_cep.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 520);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.dtp_nasc);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lblValormatricula);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD__ClienteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblValormatricula;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox dtp_nasc;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD__ClienteDataSet bD__ClienteDataSet;
        private System.Windows.Forms.BindingSource tBclienteBindingSource;
        private BD__ClienteDataSetTableAdapters.TB_clienteTableAdapter tB_clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtnascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsnumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsCepDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.MaskedTextBox msk_cep;
    }
}

