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
    public partial class frmAlterarHorario : Form
    {
        private readonly AppDbContext _db;
        private readonly UsuarioService _usuarioService;

        public frmAlterarHorario(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _usuarioService = new UsuarioService(_db);
            PopularCamposComHorarioAtual();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            VerificacaoCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AbrirConfig();
        }

        private void AbrirConfig()
        {
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
        }


        private void PopularCamposComHorarioAtual()
        {
            var horarioDTO = _usuarioService.RetonarHorarioRegistradoPeloUsuario(Properties.Settings.Default.Id);

            if (DateTime.TryParse(horarioDTO.Entrada.ToString(), out DateTime entrada1))
                txtBoxEntrada.Text = entrada1.ToString("HH:mm");
            if (DateTime.TryParse(horarioDTO.Saida.ToString(), out DateTime saida1))
                txtBoxSaida.Text = saida1.ToString("HH:mm");

        }

        private void VerificacaoCampos()
        {
            bool valor1 = VerificarCampoEntrada();
            bool valor2 = VerificarCampoSaida();
            if (valor1 && valor2)
            {
                if (DateTime.TryParse(txtBoxEntrada.Text, out DateTime entrada1)) { }
                if (DateTime.TryParse(txtBoxSaida.Text, out DateTime saida1)) { }
                if(_usuarioService.AtualizarHorarios(Properties.Settings.Default.Id, entrada1, saida1))
                    AbrirConfig();
            }
        }

        private bool VerificarCampoEntrada()
        {
            if (DateTime.TryParse(txtBoxEntrada.Text, out DateTime entrada1))
                return true;
            else
            {
                MessageBox.Show("O formato do horário de entrada é inválido. Use o formato HH:mm.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool VerificarCampoSaida()
        {
            if (DateTime.TryParse(txtBoxSaida.Text, out DateTime saida))
                return true;
            else
            {
                MessageBox.Show("O formato do horário de saida é inválido. Use o formato HH:mm.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmAlterarHorario_Load(object sender, EventArgs e)
        {

        }
    }
}
