using System.Security.Cryptography;
using WorkBalance_.Data;
using WorkBalance_.Service;
using WorkBalance_.Utility;

namespace WorkBalance_.View
{
    public partial class frmLogin : Form
    {
        private readonly LembrarDeMim lembrarDeMim = new LembrarDeMim();
        private readonly HashSenha hashSenha = new HashSenha(SHA256.Create());
        private readonly AppDbContext _db;
        private readonly UsuarioService _usuarioService;

        #region Eventos
        public frmLogin(AppDbContext db)
        {
            InitializeComponent();
            CarregarCredenciaisSalvas();
            _db = db;
            _usuarioService = new UsuarioService(_db);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
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
        }

        private void cBoxLembrarDeMim_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLembrarDeMim.Checked)
                lembrarDeMim.SalvarCredenciais(txtBoxUsuario.Text, txtBoxSenha.Text);
            else
                lembrarDeMim.DeletarCredenciais();
        }
        #endregion

        #region Metodos
        private void CarregarCredenciaisSalvas()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Usuario) && !string.IsNullOrEmpty(Properties.Settings.Default.Senha))
            {
                txtBoxUsuario.Text = Properties.Settings.Default.Usuario;
                txtBoxSenha.Text = Properties.Settings.Default.Senha;
                cBoxLembrarDeMim.Checked = true;
            }
        }
        private void Login()
        {

            if (_usuarioService.Login(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)))
            {
                Properties.Settings.Default.Id = _usuarioService.ObterUsuarioId(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text));
                AbrirFormMenuPrincipal();
            }
            else
                MessageBox.Show("Usuário ou senha incorretos!", "Erro ao efetuar login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AbrirFormMenuPrincipal()
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(_db);
            menuPrincipal.Show();
            this.Close();
        }
        #endregion
    }
}