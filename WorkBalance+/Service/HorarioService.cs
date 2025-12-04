using Microsoft.EntityFrameworkCore;
using WorkBalance_.Data;
using WorkBalance_.DTOs;
using WorkBalance_.Model;

namespace WorkBalance_.Service
{
    public class HorarioService
    {
        private readonly AppDbContext _db;
        private readonly LogErroService _logErroService;
        public HorarioService(AppDbContext db)
        {
            _db = db;
        }

        private void MensagemErro(string erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public HorarioDTO HorarioFixoDoUsuario(int Id)
        {
            try
            {
                var UsuarioHorario = _db.Usuario.FirstOrDefault(u => u.Id == Id);
                return new HorarioDTO
                {
                    Entrada = UsuarioHorario.Entrada,
                    Saida = UsuarioHorario.Saida
                };
            }
            catch (Exception ex)
            { 
                MensagemErro(ex.Message);
                _logErroService.Registrar("Buscar horário fixo do usuário", ex.Message, ex.ToString());
                return null; 
            }
        }

        public TimeSpan CalcularSaldoHoras(int id)
        {
            try
            {
                var HorarioFixo = HorarioFixoDoUsuario(id);

                DateTime.TryParse(HorarioFixo.Entrada.ToString(), out DateTime entradaPadraoDate);
                DateTime.TryParse(HorarioFixo.Saida.ToString(), out DateTime saidaPadraoDate);

                TimeSpan horaEntradaPadrao = entradaPadraoDate.TimeOfDay;
                TimeSpan horaSaidaPadrao = saidaPadraoDate.TimeOfDay;

                TimeSpan saldoTotal = TimeSpan.Zero;

                var horarios = _db.Horario.Where(h => h.UsuarioId == id).ToList();

                foreach (var h in horarios)
                {
                    TimeSpan horaEntrada = h.Entrada?.TimeOfDay ?? TimeSpan.Zero;
                    TimeSpan horaSaida = h.Saida?.TimeOfDay ?? TimeSpan.Zero;


                    TimeSpan diffEntrada = horaEntradaPadrao - horaEntrada;
                    TimeSpan diffSaida = horaSaida - horaSaidaPadrao;

                    saldoTotal += diffEntrada + diffSaida;
                }

                return saldoTotal;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Calcular saldo de horário", ex.Message, ex.ToString());
                return new TimeSpan();
            }
        }

        public (string, string) VerificarHorario(string diaHoje, int Id)
        {
            try
            {
                var horario = _db.Horario.FirstOrDefault(h => EF.Functions.Like(h.Entrada.ToString(), $"%{diaHoje}%") && h.UsuarioId == Id);

                if (horario == null)
                    return ("", "");
                var entrada = (horario.Entrada != null) ? horario.Entrada.ToString() : "?";
                var saida = (horario.Saida != null) ? horario.Saida.ToString() : "?";


                return (entrada, saida);
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Verificar horário", ex.Message, ex.ToString());
                return ("","");
            }
        }

        public bool InserirHorario(HorarioModel horarioModel)
        {
            try
            {
                if (horarioModel == null)
                    return false;

                var horario = _db.Horario.Add(horarioModel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Inserir horário", ex.Message, ex.ToString());
                return false;
            }
        }

        public bool AtualizarHorario(HorarioModel horarioModel)
        {
            try
            {
                if (horarioModel == null)
                    return false;

                string dataHoje = horarioModel.Entrada?.ToString("yyyy-MM-dd") ?? "";
                var horarioExistente = _db.Horario.FirstOrDefault(h => EF.Functions.Like(h.Entrada.ToString(), $"%{dataHoje}%") && h.UsuarioId == horarioModel.UsuarioId);

                horarioExistente.Entrada = horarioModel.Entrada;
                horarioExistente.Saida = horarioModel.Saida;
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Atualizar horário", ex.Message, ex.ToString());
                return false;
            }
        }


        public List<HorarioModel> Historico(int Id)
        {
            try { return _db.Horario.Where(h => h.UsuarioId == Id).ToList(); }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Historico", ex.Message, ex.ToString());
                return null;
            }
        }
    }
}
