namespace WorkBalance_.View
{
    partial class frmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarSenha));
            btnSair = new Button();
            btnSalvar = new Button();
            cBoxMostrarSenha = new CheckBox();
            label1 = new Label();
            txtBoxSenhaNova = new TextBox();
            txtBoxSenhaAtual = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtBoxSenhaNovamente = new TextBox();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(117, 396);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(165, 55);
            btnSair.TabIndex = 23;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(58, 123, 213);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(117, 335);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(165, 55);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.Location = new Point(122, 300);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(155, 29);
            cBoxMostrarSenha.TabIndex = 20;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(86, 148);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 19;
            label1.Text = "Senha Nova:";
            // 
            // txtBoxSenhaNova
            // 
            txtBoxSenhaNova.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNova.Location = new Point(86, 182);
            txtBoxSenhaNova.MaxLength = 60;
            txtBoxSenhaNova.Name = "txtBoxSenhaNova";
            txtBoxSenhaNova.PlaceholderText = "Insira sua senha nova...";
            txtBoxSenhaNova.Size = new Size(228, 34);
            txtBoxSenhaNova.TabIndex = 18;
            txtBoxSenhaNova.UseSystemPasswordChar = true;
            // 
            // txtBoxSenhaAtual
            // 
            txtBoxSenhaAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaAtual.Location = new Point(86, 102);
            txtBoxSenhaAtual.MaxLength = 60;
            txtBoxSenhaAtual.Name = "txtBoxSenhaAtual";
            txtBoxSenhaAtual.PlaceholderText = "Insira sua senha atual...";
            txtBoxSenhaAtual.Size = new Size(228, 34);
            txtBoxSenhaAtual.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(86, 68);
            label7.Name = "label7";
            label7.Size = new Size(143, 31);
            label7.TabIndex = 16;
            label7.Text = "Senha Atual:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(79, 9);
            label6.Name = "label6";
            label6.Size = new Size(241, 38);
            label6.TabIndex = 15;
            label6.Text = "Altere Sua Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(46, 46, 46);
            label2.Location = new Point(86, 226);
            label2.Name = "label2";
            label2.Size = new Size(237, 31);
            label2.TabIndex = 25;
            label2.Text = "Repita A Nova Senha:";
            // 
            // txtBoxSenhaNovamente
            // 
            txtBoxSenhaNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNovamente.Location = new Point(86, 260);
            txtBoxSenhaNovamente.MaxLength = 60;
            txtBoxSenhaNovamente.Name = "txtBoxSenhaNovamente";
            txtBoxSenhaNovamente.PlaceholderText = "Repita sua senha nova...";
            txtBoxSenhaNovamente.Size = new Size(228, 34);
            txtBoxSenhaNovamente.TabIndex = 24;
            txtBoxSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // frmAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(400, 468);
            Controls.Add(label2);
            Controls.Add(txtBoxSenhaNovamente);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(label1);
            Controls.Add(txtBoxSenhaNova);
            Controls.Add(txtBoxSenhaAtual);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlterarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnSalvar;
        private CheckBox cBoxMostrarSenha;
        private Label label1;
        private TextBox txtBoxSenhaNova;
        private TextBox txtBoxSenhaAtual;
        private Label label7;
        private Label label6;
        private Label label2;
        private TextBox txtBoxSenhaNovamente;
    }
}