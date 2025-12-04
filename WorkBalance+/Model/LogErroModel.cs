using System;
using System.Collections.Generic;
using System.Text;

namespace WorkBalance_.Model
{
    public class LogErroModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string? Usuario { get; set; }
        public string Funcionalidade { get; set; } = "";
        public string Mensagem { get; set; } = "";
        public string DetalhesTecnicos { get; set; } = "";
    }
}
