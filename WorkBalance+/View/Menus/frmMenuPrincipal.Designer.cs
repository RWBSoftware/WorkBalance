namespace WorkBalance_.View
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            panel1 = new Panel();
            dtHoje = new DateTimePicker();
            lblSaida = new Label();
            label4 = new Label();
            lblEntrada = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnInserir = new Button();
            btnHistorico = new Button();
            btnRelatorio = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            panel2 = new Panel();
            lblSaidaHoje = new Label();
            label10 = new Label();
            lblEntradaHoje = new Label();
            label12 = new Label();
            lblSaldoAtual = new Label();
            label7 = new Label();
            label6 = new Label();
            lblMes = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtHoje);
            panel1.Controls.Add(lblSaida);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblEntrada);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 433);
            panel1.TabIndex = 0;
            // 
            // dtHoje
            // 
            dtHoje.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtHoje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtHoje.Format = DateTimePickerFormat.Short;
            dtHoje.Location = new Point(3, 3);
            dtHoje.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtHoje.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtHoje.Name = "dtHoje";
            dtHoje.Size = new Size(241, 34);
            dtHoje.TabIndex = 6;
            dtHoje.Value = new DateTime(2025, 11, 6, 0, 0, 0, 0);
            dtHoje.ValueChanged += dtHoje_ValueChanged;
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaida.ForeColor = Color.FromArgb(46, 46, 46);
            lblSaida.Location = new Point(103, 68);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(58, 28);
            lblSaida.TabIndex = 4;
            lblSaida.Text = "18:00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 46, 46);
            label4.Location = new Point(12, 68);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 3;
            label4.Text = "Saída:";
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrada.ForeColor = Color.FromArgb(46, 46, 46);
            lblEntrada.Location = new Point(103, 40);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(61, 28);
            lblEntrada.TabIndex = 2;
            lblEntrada.Text = "08:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 1;
            label1.Text = "Entrada:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnInserir);
            flowLayoutPanel1.Controls.Add(btnHistorico);
            flowLayoutPanel1.Controls.Add(btnRelatorio);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 102);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 331);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(58, 123, 213);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(3, 3);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(247, 60);
            btnInserir.TabIndex = 2;
            btnInserir.Text = "Inserir Horas";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(58, 123, 213);
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorico.Location = new Point(3, 69);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(247, 60);
            btnHistorico.TabIndex = 3;
            btnHistorico.Text = "Historico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnEditarHoras_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(58, 123, 213);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(3, 135);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(247, 60);
            btnRelatorio.TabIndex = 4;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(58, 123, 213);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.Location = new Point(3, 201);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(247, 60);
            btnConfig.TabIndex = 5;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(58, 123, 213);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(3, 267);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(247, 60);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSaidaHoje);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblEntradaHoje);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lblSaldoAtual);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblMes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 433);
            panel2.TabIndex = 1;
            // 
            // lblSaidaHoje
            // 
            lblSaidaHoje.AutoSize = true;
            lblSaidaHoje.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblSaidaHoje.ForeColor = Color.FromArgb(46, 46, 46);
            lblSaidaHoje.Location = new Point(355, 334);
            lblSaidaHoje.Name = "lblSaidaHoje";
            lblSaidaHoje.Size = new Size(68, 31);
            lblSaidaHoje.TabIndex = 9;
            lblSaidaHoje.Text = "18:00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(46, 46, 46);
            label10.Location = new Point(196, 332);
            label10.Name = "label10";
            label10.Size = new Size(132, 31);
            label10.TabIndex = 8;
            label10.Text = "Saída Hoje:";
            // 
            // lblEntradaHoje
            // 
            lblEntradaHoje.AutoSize = true;
            lblEntradaHoje.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblEntradaHoje.ForeColor = Color.FromArgb(46, 46, 46);
            lblEntradaHoje.Location = new Point(355, 303);
            lblEntradaHoje.Name = "lblEntradaHoje";
            lblEntradaHoje.Size = new Size(72, 31);
            lblEntradaHoje.TabIndex = 7;
            lblEntradaHoje.Text = "08:00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(46, 46, 46);
            label12.Location = new Point(194, 303);
            label12.Name = "label12";
            label12.Size = new Size(155, 31);
            label12.TabIndex = 6;
            label12.Text = "Entrada Hoje:";
            // 
            // lblSaldoAtual
            // 
            lblSaldoAtual.AutoSize = true;
            lblSaldoAtual.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldoAtual.ForeColor = Color.FromArgb(46, 46, 46);
            lblSaldoAtual.Location = new Point(211, 185);
            lblSaldoAtual.Name = "lblSaldoAtual";
            lblSaldoAtual.Size = new Size(127, 46);
            lblSaldoAtual.TabIndex = 5;
            lblSaldoAtual.Text = "0h00m";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(190, 143);
            label7.Name = "label7";
            label7.Size = new Size(170, 38);
            label7.TabIndex = 4;
            label7.Text = "Saldo Atual:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(187, 9);
            label6.Name = "label6";
            label6.Size = new Size(176, 38);
            label6.TabIndex = 3;
            label6.Text = "Relatório de";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMes.ForeColor = Color.FromArgb(46, 46, 46);
            lblMes.Location = new Point(196, 47);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(157, 38);
            lblMes.TabIndex = 2;
            lblMes.Text = "Novembro";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(800, 433);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnInserir;
        private Button btnHistorico;
        private Button btnRelatorio;
        private Button btnConfig;
        private Button btnSair;
        private Label label1;
        private Label lblEntrada;
        private Label lblSaida;
        private Label label4;
        private Label lblMes;
        private Label label6;
        private Label label7;
        private Label lblSaldoAtual;
        private DateTimePicker dtHoje;
        private Label lblSaidaHoje;
        private Label label10;
        private Label lblEntradaHoje;
        private Label label12;
    }
}