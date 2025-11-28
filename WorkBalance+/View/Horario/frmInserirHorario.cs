using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkBalance_.Data;
using WorkBalance_.DTOs;
using WorkBalance_.Model;
using WorkBalance_.Service;

namespace WorkBalance_.View
{
    public partial class frmInserirHorario : Form
    {
        private readonly AppDbContext _db;
        private readonly HorarioService _horarioService;
        private HorarioDTO _horarioDTO = new HorarioDTO();
        private HorarioModel horarioModel;
        private string entradaFixa = "";
        private string saidaFixa = "";
        private DateTime DataHoje = new DateTime();

        public frmInserirHorario(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _horarioService = new HorarioService(_db);
            OrganizarData();
            ConverterDataDeHoje();
            PopularCamposComHorarioAtual();
            
        }


        private void OrganizarData()
        {
            dtHoje.Value = DateTime.Today;
            dtHoje.MaxDate = DateTime.Today;
            dtHoje.MinDate = DateTime.Today.AddDays(-365);
        }

        private void ConverterDataDeHoje()
        {
            DataHoje = dtHoje.Value;
        }

        private void PopularCamposComHorarioAtual()
        {
            int Id = Properties.Settings.Default.Id;
            (entradaFixa, saidaFixa) = _horarioService.VerificarHorario(DataHoje.ToString("yyyy-MM-dd"), Id);

            if (DateTime.TryParse(entradaFixa, out DateTime entrada1))
                txtBoxEntrada.Text = entrada1.ToString("HH:mm");
            else
                txtBoxEntrada.Text = "";

            if (DateTime.TryParse(saidaFixa, out DateTime saida1))
                txtBoxSaida.Text = saida1.ToString("HH:mm");
            else
                txtBoxSaida.Text = "";
        }

        private void AbrirMenuPrincipal()
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(_db);
            menuPrincipal.Show();
            this.Close();
        }

        private string RetornarHoraAtual()
        {
            var DataAtualEntrada = DateTime.Now;
            return DataAtualEntrada.ToString("HH:mm");
        }

        private void txtBoxEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = RetornarHoraAtual();
        }

        private void btnInserirSaida_Click(object sender, EventArgs e)
        {
            txtBoxSaida.Text = RetornarHoraAtual();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AbrirMenuPrincipal();
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            InserirHorario();
        }

        private string VerificarCampoEntrada()
        {
            if (string.IsNullOrWhiteSpace(txtBoxEntrada.Text))
            {
                MessageBox.Show("O campo de entrada está vazio. Por favor, insira um horário de entrada.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            if (DateTime.TryParse(txtBoxEntrada.Text, out DateTime entrada))
            {
                DataHoje = DataHoje.Date.AddHours(entrada.Hour).AddMinutes(entrada.Minute);

                return DataHoje.ToString();
            }
            else
            {
                MessageBox.Show("O formato do horário de entrada é inválido. Use o formato HH:mm.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private HorarioModel PopularClasseHorario(string entrada, string saida)
        {
            DateTime entradaDate;
            DateTime saidaDate;

            return horarioModel = new HorarioModel
            {
                UsuarioId = Properties.Settings.Default.Id,
                Entrada = DateTime.TryParse(entrada, out entradaDate) ? entradaDate : (DateTime?)null,
                Saida = DateTime.TryParse(saida, out saidaDate) ? saidaDate : (DateTime?)null
            };
        }


        private string VerificarCampoSaida()
        {
            if (txtBoxSaida.MaskFull)
            {
                if (!DateTime.TryParse(txtBoxSaida.Text, out DateTime saida))
                {
                    MessageBox.Show("O formato do horário de saida é inválido. Use o formato HH:mm.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }

                DataHoje = DataHoje.Date.AddHours(saida.Hour).AddMinutes(saida.Minute);
                return DataHoje.ToString();
            }

            return "";
        }


        private void InserirHorario()
        {
            var entrada = VerificarCampoEntrada();
            var saida = VerificarCampoSaida();

            if (!string.IsNullOrEmpty(entrada))
            {
                if (string.IsNullOrEmpty(entradaFixa) && string.IsNullOrEmpty(saidaFixa))
                {
                    _horarioService.InserirHorario(PopularClasseHorario(entrada, saida));
                    MessageBox.Show("Horário Inserido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AbrirForms();
                }
                else
                {
                    _horarioService.AtualizarHorario(PopularClasseHorario(entrada, saida));
                    MessageBox.Show("Horário Inserido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AbrirForms();
                }
            }
        }

        private void dtHoje_ValueChanged(object sender, EventArgs e)
        {
            ConverterDataDeHoje();
            PopularCamposComHorarioAtual();
        }

        private void AbrirForms()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
