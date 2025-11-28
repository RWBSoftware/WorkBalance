using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBalance_.Model
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
    }
}
