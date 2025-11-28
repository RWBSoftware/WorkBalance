using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBalance_.Utility
{
    public class LembrarDeMim
    {
        public void SalvarCredenciais(string usuario, string senha)
        {
            Properties.Settings.Default.Usuario = usuario;
            Properties.Settings.Default.Senha = senha;
            Properties.Settings.Default.LembrarDeMim = true;
            Properties.Settings.Default.Save();
        }

        public void DeletarCredenciais()
        {
            Properties.Settings.Default.Usuario = "";
            Properties.Settings.Default.Senha = "";
            Properties.Settings.Default.LembrarDeMim = false;
            Properties.Settings.Default.Save();
        }
    }
}
