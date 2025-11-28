namespace WorkBalance_.View
{
    partial class frmHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorico));
            dgvHorarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            SuspendLayout();
            // 
            // dgvHorarios
            // 
            dgvHorarios.AllowUserToAddRows = false;
            dgvHorarios.AllowUserToDeleteRows = false;
            dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarios.Dock = DockStyle.Fill;
            dgvHorarios.Location = new Point(0, 0);
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.ReadOnly = true;
            dgvHorarios.RowHeadersWidth = 51;
            dgvHorarios.Size = new Size(600, 450);
            dgvHorarios.TabIndex = 0;
            // 
            // frmHistorico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(600, 450);
            Controls.Add(dgvHorarios);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmHistorico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkBalance+";
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHorarios;
    }
}