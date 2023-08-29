namespace CRUDPessoas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmPessoas = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPEE = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPessoas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmPessoas
            // 
            this.tsmPessoas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastro,
            this.mniPEE});
            this.tsmPessoas.Name = "tsmPessoas";
            this.tsmPessoas.Size = new System.Drawing.Size(60, 20);
            this.tsmPessoas.Text = "Pessoas";
            // 
            // mniCadastro
            // 
            this.mniCadastro.Name = "mniCadastro";
            this.mniCadastro.Size = new System.Drawing.Size(219, 22);
            this.mniCadastro.Text = "Cadastro";
            this.mniCadastro.Click += new System.EventHandler(this.mniCadastro_Click);
            // 
            // mniPEE
            // 
            this.mniPEE.Name = "mniPEE";
            this.mniPEE.Size = new System.Drawing.Size(219, 22);
            this.mniPEE.Text = "Pesquisa, edição e exclusão";
            this.mniPEE.Click += new System.EventHandler(this.mniPEE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 74);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CRUD de Pessoas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmPessoas;
        private System.Windows.Forms.ToolStripMenuItem mniCadastro;
        private System.Windows.Forms.ToolStripMenuItem mniPEE;
    }
}

