namespace WorkBalance_.View
{
    partial class frmInserirHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirHorario));
            label6 = new Label();
            label7 = new Label();
            txtBoxEntrada = new MaskedTextBox();
            btnInserirEntrada = new Button();
            btnInserirSaida = new Button();
            txtBoxSaida = new MaskedTextBox();
            label1 = new Label();
            btnInserir = new Button();
            btnSair = new Button();
            label2 = new Label();
            dtHoje = new DateTimePicker();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(96, 9);
            label6.Name = "label6";
            label6.Size = new Size(208, 38);
            label6.TabIndex = 4;
            label6.Text = "Inserir Horário";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(49, 124);
            label7.Name = "label7";
            label7.Size = new Size(122, 38);
            label7.TabIndex = 5;
            label7.Text = "Entrada:";
            // 
            // txtBoxEntrada
            // 
            txtBoxEntrada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEntrada.Location = new Point(177, 128);
            txtBoxEntrada.Mask = "90:00";
            txtBoxEntrada.Name = "txtBoxEntrada";
            txtBoxEntrada.Size = new Size(81, 34);
            txtBoxEntrada.TabIndex = 6;
            txtBoxEntrada.ValidatingType = typeof(DateTime);
            txtBoxEntrada.KeyPress += txtBoxEntrada_KeyPress;
            // 
            // btnInserirEntrada
            // 
            btnInserirEntrada.BackColor = Color.FromArgb(58, 123, 213);
            btnInserirEntrada.FlatAppearance.BorderSize = 0;
            btnInserirEntrada.FlatStyle = FlatStyle.Flat;
            btnInserirEntrada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserirEntrada.Location = new Point(264, 124);
            btnInserirEntrada.Name = "btnInserirEntrada";
            btnInserirEntrada.Size = new Size(88, 38);
            btnInserirEntrada.TabIndex = 7;
            btnInserirEntrada.Text = "Atual";
            btnInserirEntrada.UseVisualStyleBackColor = false;
            btnInserirEntrada.Click += btnInserir_Click;
            // 
            // btnInserirSaida
            // 
            btnInserirSaida.BackColor = Color.FromArgb(58, 123, 213);
            btnInserirSaida.FlatAppearance.BorderSize = 0;
            btnInserirSaida.FlatStyle = FlatStyle.Flat;
            btnInserirSaida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserirSaida.Location = new Point(264, 173);
            btnInserirSaida.Name = "btnInserirSaida";
            btnInserirSaida.Size = new Size(88, 41);
            btnInserirSaida.TabIndex = 10;
            btnInserirSaida.Text = "Atual";
            btnInserirSaida.UseVisualStyleBackColor = false;
            btnInserirSaida.Click += btnInserirSaida_Click;
            // 
            // txtBoxSaida
            // 
            txtBoxSaida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSaida.Location = new Point(177, 176);
            txtBoxSaida.Mask = "90:00";
            txtBoxSaida.Name = "txtBoxSaida";
            txtBoxSaida.Size = new Size(81, 34);
            txtBoxSaida.TabIndex = 9;
            txtBoxSaida.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(49, 172);
            label1.Name = "label1";
            label1.Size = new Size(93, 38);
            label1.TabIndex = 8;
            label1.Text = "Saida:";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(58, 123, 213);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(117, 232);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(165, 55);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click_1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(117, 293);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(165, 55);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(46, 46, 46);
            label2.Location = new Point(48, 75);
            label2.Name = "label2";
            label2.Size = new Size(84, 38);
            label2.TabIndex = 13;
            label2.Text = "Data:";
            // 
            // dtHoje
            // 
            dtHoje.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtHoje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtHoje.Format = DateTimePickerFormat.Short;
            dtHoje.Location = new Point(177, 79);
            dtHoje.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtHoje.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtHoje.Name = "dtHoje";
            dtHoje.Size = new Size(175, 34);
            dtHoje.TabIndex = 14;
            dtHoje.Value = new DateTime(2025, 11, 6, 0, 0, 0, 0);
            dtHoje.ValueChanged += dtHoje_ValueChanged;
            // 
            // frmInserirHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(400, 383);
            Controls.Add(dtHoje);
            Controls.Add(label2);
            Controls.Add(btnSair);
            Controls.Add(btnInserir);
            Controls.Add(btnInserirSaida);
            Controls.Add(txtBoxSaida);
            Controls.Add(label1);
            Controls.Add(btnInserirEntrada);
            Controls.Add(txtBoxEntrada);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmInserirHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private MaskedTextBox txtBoxEntrada;
        private Button btnInserirEntrada;
        private Button btnInserirSaida;
        private MaskedTextBox txtBoxSaida;
        private Label label1;
        private Button btnInserir;
        private Button btnSair;
        private Label label2;
        private DateTimePicker dtHoje;
    }
}