using System.Security.Cryptography;
using WorkBalance_.Data;
using WorkBalance_.Model;
using WorkBalance_.Service;
using WorkBalance_.Utility;

namespace WorkBalance_.View
{
    public partial class frmCadastro : Form
    {
        private readonly HashSenha HashSenha = new HashSenha(SHA256.Create());
        private readonly AppDbContext _db;
        private readonly UsuarioModel _usuarioModel;
        private readonly UsuarioService _usuarioService;

        #region Eventos
        public frmCadastro(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _usuarioService = new UsuarioService(_db);
        }

        private void txtBoxEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_db);
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }
        #endregion

        #region Metodos
        private void MensagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsuario.Text))
            {
                MensagemDeErro("O campo 'Nome' está vazio. Por favor, preencha-o.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtBoxSenha.Text))
            {
                MensagemDeErro("O campo 'Senha' está vazio. Por favor, preencha-o.");
                return;
            }
            if (txtBoxSenha.Text != txtBoxSenhaNovamente.Text)
            {
                MensagemDeErro("As senhas não coincidem. Por favor, verifique e tente novamente.");
                return;
            }
            if (txtBoxUsuario.Text.Length < 3)
            {
                MensagemDeErro("O nome de usuário deve ter no máximo 3 caracteres.");
                return;
            }
            if (txtBoxSenha.Text.Length < 6)
            {
                MensagemDeErro("A senha deve ter no mínimo 6 caracteres.");
                return;
            }
            if (!txtBoxEntrada.MaskFull)
            {
                MessageBox.Show("O campo de entrada está vazio. Por favor, insira um horário de entrada.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DateTime.TryParse(txtBoxEntrada.Text, out DateTime entrada))
            {
                MessageBox.Show("O formato do horário de entrada é inválido. Use o formato HH:mm.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtBoxSaida.MaskFull)
            {
                MessageBox.Show("O campo de saida está vazio. Por favor, insira um horário de saida.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DateTime.TryParse(txtBoxSaida.Text, out DateTime saida))
            {
                MessageBox.Show("O formato do horário de saida é inválido. Use o formato HH:mm.", "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CadastrarUsuario(entrada.ToString(), saida.ToString());
        }

        private UsuarioModel PopularClasseUsuario()
        {
            return new UsuarioModel
            {
                Usuario = txtBoxUsuario.Text,
                Senha = HashSenha.CriptografarSenha(txtBoxSenha.Text),
                Entrada = DateTime.Parse(txtBoxEntrada.Text),
                Saida = DateTime.Parse(txtBoxSaida.Text),
            };
        }

        private void CadastrarUsuario(string entrada, string saida)
        {
            if (_usuarioService.Cadastrar(PopularClasseUsuario()))
            {
                Properties.Settings.Default.Id = _usuarioService.ObterUsuarioId(txtBoxUsuario.Text, HashSenha.CriptografarSenha(txtBoxSenha.Text));
                AbrirFormsMenuPrincipal();
            }
            else
            {
                MensagemDeErro("Erro ao cadastrar o usuário. Tente novamente.");
                return;
            }
        }

        private void AbrirFormsMenuPrincipal()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }
        #endregion
    }
}
