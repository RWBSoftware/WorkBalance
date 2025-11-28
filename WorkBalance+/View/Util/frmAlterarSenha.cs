using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WorkBalance_.Data;
using WorkBalance_.Service;
using WorkBalance_.Utility;

namespace WorkBalance_.View
{
    public partial class frmAlterarSenha : Form
    {
        private HashSenha hashSenha = new HashSenha(SHA256.Create());
        private readonly AppDbContext _db;
        private readonly UsuarioService _usuarioService;


        public frmAlterarSenha(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _usuarioService = new UsuarioService(db);
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenhaAtual.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNova.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AbrirFormsConfig();
        }

        private void AbrirFormsConfig()
        {
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
        }

        private void VerificarCampos()
        {
            if(txtBoxSenhaAtual.Text != Properties.Settings.Default.Senha)
            {
                MessageBox.Show("A senha atual está incorreta.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxSenhaAtual.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSenhaNova.Text) ||
                string.IsNullOrWhiteSpace(txtBoxSenhaNovamente.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(txtBoxSenhaNova.Text.Length < 6)
            {
                MessageBox.Show("A nova senha deve ter pelo menos 6 caracteres.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBoxSenhaNova.Text != txtBoxSenhaNovamente.Text)
            {
                MessageBox.Show("A nova senha e a confirmação não coincidem.", "Erro de Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtBoxSenhaNova.Text == Properties.Settings.Default.Senha)
                {
                MessageBox.Show("A nova senha não pode ser igual à senha atual.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AtualizarSenha();

        }

        private void AtualizarSenha()
        {
            if (_usuarioService.AtualizarSenha(Properties.Settings.Default.Id, hashSenha.CriptografarSenha(txtBoxSenhaNova.Text)))
            {
                Properties.Settings.Default.Senha = txtBoxSenhaNova.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AbrirFormsConfig();
            }
        }
    }
}
