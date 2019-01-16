namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.btnnovofun = new System.Windows.Forms.Button();
            this.btnnovocli = new System.Windows.Forms.Button();
            this.novoagendamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnovofun
            // 
            this.btnnovofun.Location = new System.Drawing.Point(12, 12);
            this.btnnovofun.Name = "btnnovofun";
            this.btnnovofun.Size = new System.Drawing.Size(75, 23);
            this.btnnovofun.TabIndex = 0;
            this.btnnovofun.Text = "Funcionários";
            this.btnnovofun.UseVisualStyleBackColor = true;
            this.btnnovofun.Click += new System.EventHandler(this.btnnovofun_Click);
            // 
            // btnnovocli
            // 
            this.btnnovocli.Location = new System.Drawing.Point(93, 12);
            this.btnnovocli.Name = "btnnovocli";
            this.btnnovocli.Size = new System.Drawing.Size(75, 23);
            this.btnnovocli.TabIndex = 1;
            this.btnnovocli.Text = "Clientes";
            this.btnnovocli.UseVisualStyleBackColor = true;
            this.btnnovocli.Click += new System.EventHandler(this.btnnovocli_Click);
            // 
            // novoagendamento
            // 
            this.novoagendamento.Location = new System.Drawing.Point(174, 12);
            this.novoagendamento.Name = "novoagendamento";
            this.novoagendamento.Size = new System.Drawing.Size(91, 23);
            this.novoagendamento.TabIndex = 2;
            this.novoagendamento.Text = "Agendamento";
            this.novoagendamento.UseVisualStyleBackColor = true;
            this.novoagendamento.Click += new System.EventHandler(this.novoagendamento_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 63);
            this.Controls.Add(this.novoagendamento);
            this.Controls.Add(this.btnnovocli);
            this.Controls.Add(this.btnnovofun);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnovofun;
        private System.Windows.Forms.Button btnnovocli;
        private System.Windows.Forms.Button novoagendamento;
    }
}

