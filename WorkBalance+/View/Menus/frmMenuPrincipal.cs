using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;
using WorkBalance_.Data;
using WorkBalance_.Model;
using WorkBalance_.Service;

namespace WorkBalance_.View
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly AppDbContext _db;
        private readonly UsuarioModel _usuarioModel;
        private readonly UsuarioService _usuarioService;
        private readonly HorarioService _horarioService;
        private DateTime DataHoje = new DateTime();

        #region Eventos
        public frmMenuPrincipal(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _usuarioService = new UsuarioService(_db);
            _horarioService = new HorarioService(_db);
            InicializarProjeto();
        }

        private void OrganizarData()
        {
            dtHoje.Value = DateTime.Today;
            dtHoje.MaxDate = DateTime.Today;
            dtHoje.MinDate = DateTime.Today.AddDays(-365);
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmInserirHorario frmInserirHorario = new frmInserirHorario(_db);
            frmInserirHorario.Show();
            this.Close();
        }

        private void btnEditarHoras_Click(object sender, EventArgs e)
        {
            frmHistorico historico = new frmHistorico(_db);
            historico.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig config = new frmConfig(_db);
            config.Show();
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento!", "Em desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion


        #region Metodos
        private void InicializarProjeto()
        {
            OrganizarData();
            VerificarSaldoAtual();
            DiaHoje();
            PopularLabelsHorariosUsuario();
            AtualizarEntradaSaidaHoje();
            MesAtual();
        }

        private void VerificarSaldoAtual()
        {
            TimeSpan saldo = _horarioService.CalcularSaldoHoras(Properties.Settings.Default.Id);
            string sinal = saldo.TotalMinutes >= 0 ? "+" : "-";
            VerificarCoresSaldo(sinal);
            lblSaldoAtual.Text = $"{sinal}{Math.Abs(saldo.Hours)}h {Math.Abs(saldo.Minutes)}min";

        }

        private void MesAtual()
        {
            lblMes.Text = DateTime.Now.ToString("MMMM");
        }

        private void DiaHoje()
        {
            dtHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void PopularLabelsHorariosUsuario()
        {
            var horarioFixo = _horarioService.HorarioFixoDoUsuario(Properties.Settings.Default.Id);

            if (DateTime.TryParse(horarioFixo.Entrada.ToString(), out DateTime entrada))
                lblEntrada.Text = entrada.ToString("HH:mm");
            if (DateTime.TryParse(horarioFixo.Saida.ToString(), out DateTime saida))
                lblSaida.Text = saida.ToString("HH:mm");
        }
        private void VerificarCoresSaldo(string sinal)
        {
            switch (sinal)
            {
                case "+":
                    lblSaldoAtual.ForeColor = Color.FromArgb(52, 199, 89);
                    break;
                case "-":
                    lblSaldoAtual.ForeColor = Color.FromArgb(255, 69, 58);
                    break;
            }
        }
        private void AtualizarEntradaSaidaHoje()
        {
            (var entrada, var saida) = _horarioService.VerificarHorario(DataHoje.ToString("yyyy-MM-dd"), Properties.Settings.Default.Id);

            if (DateTime.TryParse(entrada, out DateTime entradaHoje))
                lblEntradaHoje.Text = entradaHoje.ToString("HH:mm");
            else
                lblEntradaHoje.Text = "?";

            if (DateTime.TryParse(saida, out DateTime saidaHoje))
                lblSaidaHoje.Text = saidaHoje.ToString("HH:mm");
            else
                lblSaidaHoje.Text = "?";
        }
        #endregion

        private void dtHoje_ValueChanged(object sender, EventArgs e)
        {
            DataHoje = dtHoje.Value;
            AtualizarEntradaSaidaHoje();
        }
    }
}
