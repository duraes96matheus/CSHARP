namespace Etec.consultoriomedico.IU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEleitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCanditadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblhora = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunoToolStripMenuItem,
            this.cadastroDeEleitorToolStripMenuItem,
            this.cadastroDeCanditadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeAlunoToolStripMenuItem
            // 
            this.cadastroDeAlunoToolStripMenuItem.Name = "cadastroDeAlunoToolStripMenuItem";
            this.cadastroDeAlunoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.cadastroDeAlunoToolStripMenuItem.Text = "Cadastro de Aluno";
            this.cadastroDeAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunoToolStripMenuItem_Click);
            // 
            // cadastroDeEleitorToolStripMenuItem
            // 
            this.cadastroDeEleitorToolStripMenuItem.Name = "cadastroDeEleitorToolStripMenuItem";
            this.cadastroDeEleitorToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.cadastroDeEleitorToolStripMenuItem.Text = "Cadastro de Eleitor";
            this.cadastroDeEleitorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeEleitorToolStripMenuItem_Click);
            // 
            // cadastroDeCanditadoToolStripMenuItem
            // 
            this.cadastroDeCanditadoToolStripMenuItem.Name = "cadastroDeCanditadoToolStripMenuItem";
            this.cadastroDeCanditadoToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.cadastroDeCanditadoToolStripMenuItem.Text = "Cadastro de Canditado";
            this.cadastroDeCanditadoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCanditadoToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(12, 237);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(0, 16);
            this.lblhora.TabIndex = 1;
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 262);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEleitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCanditadoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblhora;
    }
}

