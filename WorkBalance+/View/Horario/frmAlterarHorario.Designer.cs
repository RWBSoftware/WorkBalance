namespace WorkBalance_.View
{
    partial class frmAlterarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarHorario));
            btnSair = new Button();
            btnAlterar = new Button();
            txtBoxSaida = new MaskedTextBox();
            label1 = new Label();
            txtBoxEntrada = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(117, 272);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(165, 55);
            btnSair.TabIndex = 21;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(58, 123, 213);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(117, 212);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(165, 55);
            btnAlterar.TabIndex = 20;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtBoxSaida
            // 
            txtBoxSaida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSaida.Location = new Point(226, 149);
            txtBoxSaida.Mask = "90:00";
            txtBoxSaida.Name = "txtBoxSaida";
            txtBoxSaida.Size = new Size(81, 34);
            txtBoxSaida.TabIndex = 18;
            txtBoxSaida.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(98, 145);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 17;
            label1.Text = "Saida:";
            // 
            // txtBoxEntrada
            // 
            txtBoxEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEntrada.Location = new Point(226, 99);
            txtBoxEntrada.Mask = "90:00";
            txtBoxEntrada.Name = "txtBoxEntrada";
            txtBoxEntrada.Size = new Size(81, 34);
            txtBoxEntrada.TabIndex = 15;
            txtBoxEntrada.ValidatingType = typeof(DateTime);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(98, 95);
            label7.Name = "label7";
            label7.Size = new Size(122, 38);
            label7.TabIndex = 14;
            label7.Text = "Entrada:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(96, 18);
            label6.Name = "label6";
            label6.Size = new Size(216, 38);
            label6.TabIndex = 13;
            label6.Text = "Alterar Horário";
            // 
            // frmAlterarHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(400, 345);
            Controls.Add(btnSair);
            Controls.Add(btnAlterar);
            Controls.Add(txtBoxSaida);
            Controls.Add(label1);
            Controls.Add(txtBoxEntrada);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlterarHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            Load += frmAlterarHorario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnAlterar;
        private MaskedTextBox txtBoxSaida;
        private Label label1;
        private MaskedTextBox txtBoxEntrada;
        private Label label7;
        private Label label6;
    }
}