namespace WorkBalance_.View
{
    partial class frmAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvaliacao));
            label1 = new Label();
            txtBoxSenha = new TextBox();
            txtBoxUsuario = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnSair = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(68, 146);
            label1.Name = "label1";
            label1.Size = new Size(231, 31);
            label1.TabIndex = 15;
            label1.Text = "Descrição(Opcional):";
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.Location = new Point(68, 180);
            txtBoxSenha.MaxLength = 400;
            txtBoxSenha.Multiline = true;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Insira uma descrição...";
            txtBoxSenha.Size = new Size(228, 168);
            txtBoxSenha.TabIndex = 14;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(68, 102);
            txtBoxUsuario.MaxLength = 1;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Insira uma nota...";
            txtBoxUsuario.Size = new Size(228, 34);
            txtBoxUsuario.TabIndex = 13;
            txtBoxUsuario.KeyPress += txtBoxUsuario_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(68, 68);
            label7.Name = "label7";
            label7.Size = new Size(123, 31);
            label7.TabIndex = 12;
            label7.Text = "Nota(0-5):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(63, 9);
            label6.Name = "label6";
            label6.Size = new Size(280, 38);
            label6.TabIndex = 11;
            label6.Text = "Deixe Sua Avaliação";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(105, 415);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(165, 55);
            btnSair.TabIndex = 17;
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
            btnSalvar.Location = new Point(105, 354);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(165, 55);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(400, 497);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAvaliacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private Label label7;
        private Label label6;
        private Button btnSair;
        private Button btnSalvar;
    }
}