namespace WindowsFormsApplication1
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
            this.DGVclientes = new System.Windows.Forms.DataGridView();
            this.DVG2 = new System.Windows.Forms.DataGridView();
            this.DVG3 = new System.Windows.Forms.DataGridView();
            this.btnCadastrarNovos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG3)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVclientes
            // 
            this.DGVclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclientes.Location = new System.Drawing.Point(12, 12);
            this.DGVclientes.Name = "DGVclientes";
            this.DGVclientes.Size = new System.Drawing.Size(425, 150);
            this.DGVclientes.TabIndex = 0;
            this.DGVclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVclientes_CellContentClick);
            // 
            // DVG2
            // 
            this.DVG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG2.Location = new System.Drawing.Point(12, 210);
            this.DVG2.Name = "DVG2";
            this.DVG2.Size = new System.Drawing.Size(425, 174);
            this.DVG2.TabIndex = 1;
            this.DVG2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG2_CellContentClick);
            // 
            // DVG3
            // 
            this.DVG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG3.Location = new System.Drawing.Point(455, 12);
            this.DVG3.Name = "DVG3";
            this.DVG3.Size = new System.Drawing.Size(414, 306);
            this.DVG3.TabIndex = 2;
            this.DVG3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG3_CellContentClick);
            // 
            // btnCadastrarNovos
            // 
            this.btnCadastrarNovos.Location = new System.Drawing.Point(468, 335);
            this.btnCadastrarNovos.Name = "btnCadastrarNovos";
            this.btnCadastrarNovos.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarNovos.TabIndex = 3;
            this.btnCadastrarNovos.Text = "Cadastrar";
            this.btnCadastrarNovos.UseVisualStyleBackColor = true;
            this.btnCadastrarNovos.Click += new System.EventHandler(this.btnCadastrarNovos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 396);
            this.Controls.Add(this.btnCadastrarNovos);
            this.Controls.Add(this.DVG3);
            this.Controls.Add(this.DVG2);
            this.Controls.Add(this.DGVclientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVclientes;
        private System.Windows.Forms.DataGridView DVG2;
        private System.Windows.Forms.DataGridView DVG3;
        private System.Windows.Forms.Button btnCadastrarNovos;
    }
}

