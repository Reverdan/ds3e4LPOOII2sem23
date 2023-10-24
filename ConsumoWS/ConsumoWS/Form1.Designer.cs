namespace ConsumoWS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogradouro = new Label();
            txbLogradouro = new TextBox();
            txbBairro = new TextBox();
            lblBairro = new Label();
            txbCidade = new TextBox();
            lblCidade = new Label();
            txbCep = new TextBox();
            lblCep = new Label();
            btnPesquisar = new Button();
            SuspendLayout();
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(19, 31);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 0;
            lblLogradouro.Text = "Logradouro";
            // 
            // txbLogradouro
            // 
            txbLogradouro.Location = new Point(97, 23);
            txbLogradouro.Name = "txbLogradouro";
            txbLogradouro.Size = new Size(232, 23);
            txbLogradouro.TabIndex = 1;
            // 
            // txbBairro
            // 
            txbBairro.Location = new Point(97, 73);
            txbBairro.Name = "txbBairro";
            txbBairro.Size = new Size(232, 23);
            txbBairro.TabIndex = 3;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(19, 81);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 2;
            lblBairro.Text = "Bairro";
            // 
            // txbCidade
            // 
            txbCidade.Location = new Point(97, 126);
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(232, 23);
            txbCidade.TabIndex = 5;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(19, 134);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 4;
            lblCidade.Text = "Cidade";
            // 
            // txbCep
            // 
            txbCep.Location = new Point(97, 180);
            txbCep.Name = "txbCep";
            txbCep.Size = new Size(120, 23);
            txbCep.TabIndex = 7;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(19, 188);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 6;
            lblCep.Text = "CEP";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(254, 180);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 247);
            Controls.Add(btnPesquisar);
            Controls.Add(txbCep);
            Controls.Add(lblCep);
            Controls.Add(txbCidade);
            Controls.Add(lblCidade);
            Controls.Add(txbBairro);
            Controls.Add(lblBairro);
            Controls.Add(txbLogradouro);
            Controls.Add(lblLogradouro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogradouro;
        private TextBox txbLogradouro;
        private TextBox txbBairro;
        private Label lblBairro;
        private TextBox txbCidade;
        private Label lblCidade;
        private TextBox txbCep;
        private Label lblCep;
        private Button btnPesquisar;
    }
}