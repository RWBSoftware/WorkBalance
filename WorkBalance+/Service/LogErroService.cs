using WorkBalance_.Data;
using WorkBalance_.Model;

namespace WorkBalance_.Service
{
    public class LogErroService
    {
        private readonly AppDbContext _db;

        public LogErroService(AppDbContext db)
        {
            _db = db;
        }

        public void Registrar(string funcionalidade, string mensagem, string detalhes)
        {
            var log = new LogErroModel()
            {
                Usuario = "",
                Funcionalidade = funcionalidade,
                Mensagem = mensagem,
                DetalhesTecnicos = detalhes
            };

            _db.LogErro.Add(log);
            _db.SaveChanges();
        }
    }

}
