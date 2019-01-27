namespace Estados.cs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvestado = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHabitantes = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(137, 10);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(185, 20);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvestado
            // 
            this.dgvestado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestado.Location = new System.Drawing.Point(12, 71);
            this.dgvestado.Name = "dgvestado";
            this.dgvestado.Size = new System.Drawing.Size(407, 319);
            this.dgvestado.TabIndex = 3;
            this.dgvestado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestado_CellContentDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblHabitantes
            // 
            this.lblHabitantes.AutoSize = true;
            this.lblHabitantes.Location = new System.Drawing.Point(471, 42);
            this.lblHabitantes.Name = "lblHabitantes";
            this.lblHabitantes.Size = new System.Drawing.Size(58, 13);
            this.lblHabitantes.TabIndex = 5;
            this.lblHabitantes.Text = "Habitantes";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(488, 97);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 420);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.lblHabitantes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvestado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvestado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHabitantes;
        private System.Windows.Forms.Button btnsalvar;
    }
}

