namespace TCC
{
    partial class LoginSolicitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSolicitante));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginsoli = new System.Windows.Forms.Button();
            this.esquecisenhasoli = new System.Windows.Forms.Label();
            this.EsqueciSolici = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 219);
            this.textBox2.MaxLength = 16;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Password";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // loginsoli
            // 
            this.loginsoli.Location = new System.Drawing.Point(323, 292);
            this.loginsoli.Name = "loginsoli";
            this.loginsoli.Size = new System.Drawing.Size(103, 27);
            this.loginsoli.TabIndex = 4;
            this.loginsoli.Text = "Login";
            this.loginsoli.UseVisualStyleBackColor = true;
            // 
            // esquecisenhasoli
            // 
            this.esquecisenhasoli.AutoSize = true;
            this.esquecisenhasoli.Location = new System.Drawing.Point(453, 266);
            this.esquecisenhasoli.Name = "esquecisenhasoli";
            this.esquecisenhasoli.Size = new System.Drawing.Size(0, 13);
            this.esquecisenhasoli.TabIndex = 5;
            // 
            // EsqueciSolici
            // 
            this.EsqueciSolici.AutoSize = true;
            this.EsqueciSolici.Location = new System.Drawing.Point(381, 253);
            this.EsqueciSolici.Name = "EsqueciSolici";
            this.EsqueciSolici.Size = new System.Drawing.Size(108, 13);
            this.EsqueciSolici.TabIndex = 6;
            this.EsqueciSolici.TabStop = true;
            this.EsqueciSolici.Text = "Esqueci minha senha";
            // 
            // LoginSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.EsqueciSolici);
            this.Controls.Add(this.esquecisenhasoli);
            this.Controls.Add(this.loginsoli);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "LoginSolicitante";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSolicitante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button loginsoli;
        private System.Windows.Forms.Label esquecisenhasoli;
        private System.Windows.Forms.LinkLabel EsqueciSolici;

    }
}