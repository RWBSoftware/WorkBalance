using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkBalance_.Data;

namespace WorkBalance_.View
{
    public partial class frmAvaliacao : Form
    {
        private readonly AppDbContext _db;
        public frmAvaliacao(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void txtBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            AbrirMenuPrincipal();
        }

        private void VerificarCampos()
        {
            int nota = Convert.ToInt32(txtBoxUsuario.Text);
            if (nota < 1 || nota > 5)
            {
                MessageBox.Show("Por favor, insira uma nota válida entre 1 e 5.");
                return;
            }

            MessageBox.Show("Obrigado pela sua avaliação!", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AbrirMenuPrincipal();

        }

        private void AbrirMenuPrincipal()
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(_db);
            menuPrincipal.Show();
            this.Close();

        }
    }
}
