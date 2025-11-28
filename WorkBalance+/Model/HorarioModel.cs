using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBalance_.Model
{
    public class HorarioModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
    }
}
