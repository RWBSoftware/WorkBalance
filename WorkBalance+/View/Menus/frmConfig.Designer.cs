namespace WorkBalance_.View
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            btnAlterarHorario = new Button();
            btnAlterarSenha = new Button();
            btnAlterarConta = new Button();
            btnAvaliacao = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnAlterarHorario
            // 
            btnAlterarHorario.BackColor = Color.FromArgb(58, 123, 213);
            btnAlterarHorario.FlatAppearance.BorderSize = 0;
            btnAlterarHorario.FlatStyle = FlatStyle.Flat;
            btnAlterarHorario.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterarHorario.Location = new Point(76, 12);
            btnAlterarHorario.Name = "btnAlterarHorario";
            btnAlterarHorario.Size = new Size(247, 60);
            btnAlterarHorario.TabIndex = 3;
            btnAlterarHorario.Text = "Alterar Horário";
            btnAlterarHorario.UseVisualStyleBackColor = false;
            btnAlterarHorario.Click += btnAlterarHorario_Click;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.BackColor = Color.FromArgb(58, 123, 213);
            btnAlterarSenha.FlatAppearance.BorderSize = 0;
            btnAlterarSenha.FlatStyle = FlatStyle.Flat;
            btnAlterarSenha.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterarSenha.Location = new Point(76, 78);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(247, 60);
            btnAlterarSenha.TabIndex = 4;
            btnAlterarSenha.Text = "Alterar Senha";
            btnAlterarSenha.UseVisualStyleBackColor = false;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // btnAlterarConta
            // 
            btnAlterarConta.BackColor = Color.FromArgb(58, 123, 213);
            btnAlterarConta.FlatAppearance.BorderSize = 0;
            btnAlterarConta.FlatStyle = FlatStyle.Flat;
            btnAlterarConta.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterarConta.Location = new Point(76, 144);
            btnAlterarConta.Name = "btnAlterarConta";
            btnAlterarConta.Size = new Size(247, 60);
            btnAlterarConta.TabIndex = 5;
            btnAlterarConta.Text = "Alterar Conta";
            btnAlterarConta.UseVisualStyleBackColor = false;
            btnAlterarConta.Click += btnAlterarConta_Click;
            // 
            // btnAvaliacao
            // 
            btnAvaliacao.BackColor = Color.FromArgb(58, 123, 213);
            btnAvaliacao.FlatAppearance.BorderSize = 0;
            btnAvaliacao.FlatStyle = FlatStyle.Flat;
            btnAvaliacao.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvaliacao.Location = new Point(76, 210);
            btnAvaliacao.Name = "btnAvaliacao";
            btnAvaliacao.Size = new Size(247, 60);
            btnAvaliacao.TabIndex = 6;
            btnAvaliacao.Text = "Avaliação";
            btnAvaliacao.UseVisualStyleBackColor = false;
            btnAvaliacao.Click += btnAvaliacao_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(76, 276);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(247, 60);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(400, 351);
            Controls.Add(btnSair);
            Controls.Add(btnAvaliacao);
            Controls.Add(btnAlterarConta);
            Controls.Add(btnAlterarSenha);
            Controls.Add(btnAlterarHorario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlterarHorario;
        private Button btnAlterarSenha;
        private Button btnAlterarConta;
        private Button btnAvaliacao;
        private Button btnSair;
    }
}