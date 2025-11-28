namespace WorkBalance_.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label6 = new Label();
            label7 = new Label();
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            label1 = new Label();
            cBoxMostrarSenha = new CheckBox();
            cBoxLembrarDeMim = new CheckBox();
            btnSair = new Button();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(81, 9);
            label6.Name = "label6";
            label6.Size = new Size(238, 38);
            label6.TabIndex = 5;
            label6.Text = "Efetue Seu Login";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(86, 68);
            label7.Name = "label7";
            label7.Size = new Size(100, 31);
            label7.TabIndex = 6;
            label7.Text = "Usuário:";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(86, 102);
            txtBoxUsuario.MaxLength = 60;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Insira seu usuário...";
            txtBoxUsuario.Size = new Size(228, 34);
            txtBoxUsuario.TabIndex = 7;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.Location = new Point(86, 180);
            txtBoxSenha.MaxLength = 60;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Insira sua senha...";
            txtBoxSenha.Size = new Size(228, 34);
            txtBoxSenha.TabIndex = 9;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(86, 146);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 10;
            label1.Text = "Senha:";
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.Location = new Point(122, 220);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(155, 29);
            cBoxMostrarSenha.TabIndex = 11;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // cBoxLembrarDeMim
            // 
            cBoxLembrarDeMim.AutoSize = true;
            cBoxLembrarDeMim.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxLembrarDeMim.Location = new Point(114, 255);
            cBoxLembrarDeMim.Name = "cBoxLembrarDeMim";
            cBoxLembrarDeMim.Size = new Size(172, 29);
            cBoxLembrarDeMim.TabIndex = 12;
            cBoxLembrarDeMim.Text = "Lembrar de Mim";
            cBoxLembrarDeMim.UseVisualStyleBackColor = true;
            cBoxLembrarDeMim.CheckedChanged += cBoxLembrarDeMim_CheckedChanged;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(117, 354);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(165, 55);
            btnSair.TabIndex = 14;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(58, 123, 213);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(117, 293);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(165, 55);
            btnEntrar.TabIndex = 13;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(400, 450);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(cBoxLembrarDeMim);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private Label label1;
        private CheckBox cBoxMostrarSenha;
        private CheckBox cBoxLembrarDeMim;
        private Button btnSair;
        private Button btnEntrar;
    }
}