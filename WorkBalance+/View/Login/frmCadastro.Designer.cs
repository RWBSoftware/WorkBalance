namespace WorkBalance_.View
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            label6 = new Label();
            btnSair = new Button();
            btnEntrar = new Button();
            cBoxMostrarSenha = new CheckBox();
            label1 = new Label();
            txtBoxSenha = new TextBox();
            txtBoxUsuario = new TextBox();
            label7 = new Label();
            label2 = new Label();
            txtBoxSenhaNovamente = new TextBox();
            txtBoxEntrada = new MaskedTextBox();
            label3 = new Label();
            txtBoxSaida = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(60, 9);
            label6.Name = "label6";
            label6.Size = new Size(280, 38);
            label6.TabIndex = 6;
            label6.Text = "Efetue Seu Cadastro";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(117, 475);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(165, 55);
            btnSair.TabIndex = 22;
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
            btnEntrar.Location = new Point(117, 414);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(165, 55);
            btnEntrar.TabIndex = 21;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.Location = new Point(122, 379);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(155, 29);
            cBoxMostrarSenha.TabIndex = 19;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(86, 133);
            label1.Name = "label1";
            label1.Size = new Size(83, 31);
            label1.TabIndex = 18;
            label1.Text = "Senha:";
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.Location = new Point(86, 167);
            txtBoxSenha.MaxLength = 60;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Insira sua senha...";
            txtBoxSenha.Size = new Size(228, 34);
            txtBoxSenha.TabIndex = 17;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(86, 89);
            txtBoxUsuario.MaxLength = 60;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Insira seu usuário...";
            txtBoxUsuario.Size = new Size(228, 34);
            txtBoxUsuario.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(86, 55);
            label7.Name = "label7";
            label7.Size = new Size(100, 31);
            label7.TabIndex = 15;
            label7.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(46, 46, 46);
            label2.Location = new Point(86, 215);
            label2.Name = "label2";
            label2.Size = new Size(210, 31);
            label2.TabIndex = 24;
            label2.Text = "Senha Novamente:";
            // 
            // txtBoxSenhaNovamente
            // 
            txtBoxSenhaNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNovamente.Location = new Point(86, 249);
            txtBoxSenhaNovamente.MaxLength = 60;
            txtBoxSenhaNovamente.Name = "txtBoxSenhaNovamente";
            txtBoxSenhaNovamente.PlaceholderText = "Insira sua senha novamente...";
            txtBoxSenhaNovamente.Size = new Size(228, 34);
            txtBoxSenhaNovamente.TabIndex = 23;
            txtBoxSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // txtBoxEntrada
            // 
            txtBoxEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEntrada.Location = new Point(192, 290);
            txtBoxEntrada.Mask = "90:00";
            txtBoxEntrada.Name = "txtBoxEntrada";
            txtBoxEntrada.Size = new Size(122, 34);
            txtBoxEntrada.TabIndex = 25;
            txtBoxEntrada.ValidatingType = typeof(DateTime);
            txtBoxEntrada.KeyPress += txtBoxEntrada_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(46, 46, 46);
            label3.Location = new Point(86, 290);
            label3.Name = "label3";
            label3.Size = new Size(100, 31);
            label3.TabIndex = 26;
            label3.Text = "Entrada:";
            // 
            // txtBoxSaida
            // 
            txtBoxSaida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSaida.Location = new Point(191, 330);
            txtBoxSaida.Mask = "90:00";
            txtBoxSaida.Name = "txtBoxSaida";
            txtBoxSaida.Size = new Size(123, 34);
            txtBoxSaida.TabIndex = 27;
            txtBoxSaida.ValidatingType = typeof(DateTime);
            txtBoxSaida.KeyPress += txtBoxSaida_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 46, 46);
            label4.Location = new Point(86, 331);
            label4.Name = "label4";
            label4.Size = new Size(77, 31);
            label4.TabIndex = 28;
            label4.Text = "Saida:";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(400, 547);
            Controls.Add(label4);
            Controls.Add(txtBoxSaida);
            Controls.Add(label3);
            Controls.Add(txtBoxEntrada);
            Controls.Add(label2);
            Controls.Add(txtBoxSenhaNovamente);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnSair;
        private Button btnEntrar;
        private CheckBox cBoxMostrarSenha;
        private Label label1;
        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private Label label7;
        private Label label2;
        private TextBox txtBoxSenhaNovamente;
        private MaskedTextBox txtBoxEntrada;
        private Label label3;
        private MaskedTextBox txtBoxSaida;
        private Label label4;
    }
}