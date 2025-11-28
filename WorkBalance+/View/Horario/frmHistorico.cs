using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkBalance_.Data;
using WorkBalance_.Model;
using WorkBalance_.Service;

namespace WorkBalance_.View
{
    public partial class frmHistorico : Form
    {
        private readonly AppDbContext _db;
        private readonly HorarioService _horarioService;

        public frmHistorico(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _horarioService = new HorarioService(db);
            PopularDGV();
            ConfigurarDGV();
        }

        private void PopularDGV()
        {
            dgvHorarios.DataSource = _horarioService.Historico(Properties.Settings.Default.Id);
        }
        private void ConfigurarDGV()
        {
            dgvHorarios.ReadOnly = true;
            dgvHorarios.AllowUserToAddRows = false;
            dgvHorarios.AllowUserToDeleteRows = false;
            dgvHorarios.MultiSelect = false;
            dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHorarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHorarios.RowHeadersVisible = false;
            dgvHorarios.BackgroundColor = Color.White;
            dgvHorarios.BorderStyle = BorderStyle.None;
            dgvHorarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHorarios.EnableHeadersVisualStyles = false;
            dgvHorarios.GridColor = Color.LightGray;

            // Cabeçalho (design corporativo)
            dgvHorarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 81, 181); // Azul RWB
            dgvHorarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHorarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHorarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHorarios.ColumnHeadersHeight = 35;

            // Linhas
            dgvHorarios.DefaultCellStyle.BackColor = Color.White;
            dgvHorarios.DefaultCellStyle.ForeColor = Color.Black;
            dgvHorarios.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvHorarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 234, 246); // Azul claro
            dgvHorarios.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvHorarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Colunas
            dgvHorarios.Columns["Id"].Visible = false;
            dgvHorarios.Columns["UsuarioId"].Visible = false;
            }

    }
}
