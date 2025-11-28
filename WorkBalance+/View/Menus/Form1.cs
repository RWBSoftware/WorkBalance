using WorkBalance_.Data;
using WorkBalance_.View;

namespace WorkBalance_
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _db;
        public Form1(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(_db);
            frmLogin.Show();
            this.Hide();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro(_db);
            frmCadastro.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
