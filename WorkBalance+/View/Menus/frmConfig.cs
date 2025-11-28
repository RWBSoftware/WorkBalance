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
    public partial class frmConfig : Form
    {
        private readonly AppDbContext _db;
        public frmConfig(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnAlterarHorario_Click(object sender, EventArgs e)
        {
            frmAlterarHorario frmAlterarHorario = new frmAlterarHorario(_db);
            frmAlterarHorario.Show();
            this.Close();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frmAlterarSenha = new frmAlterarSenha(_db);
            frmAlterarSenha.Show();
            this.Close();
        }

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_db);
            form1.Show();
            this.Close();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            frmAvaliacao frmAvaliacao = new frmAvaliacao(_db);
            frmAvaliacao.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }
    }
}
