using System;
using System.Collections.Generic;
using System.Text;
using WorkBalance_.Data;
using WorkBalance_.DTOs;
using WorkBalance_.Model;

namespace WorkBalance_.Service
{
    public class UsuarioService
    {
        private readonly AppDbContext _db;
        private readonly LogErroService _logErroService;
        public UsuarioService(AppDbContext db)
        {
            _db = db;
        }

        private void MensagemErro(string erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Login(string usuario, string senha)
        {
            try
            {
                return _db.Usuario.Any(u => u.Usuario == usuario && u.Senha == senha);
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Efetuar login", ex.Message, ex.ToString());
                return false;
            }
        }

        public int ObterUsuarioId(string usuario, string senha)
        {
            try
            {
                var UsuarioLogado = _db.Usuario.FirstOrDefault(u => u.Usuario == usuario && u.Senha == senha);
                return UsuarioLogado.Id;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Obter ID", ex.Message, ex.ToString());
                return 0;
            }
        }

        public bool Cadastrar(UsuarioModel usuarioModel)
        {
            try{
                if (usuarioModel == null)
                    return false;

                _db.Usuario.Add(usuarioModel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Cadastrar usuário", ex.Message, ex.ToString());
                return false;
            }
        }

        public HorarioDTO RetonarHorarioRegistradoPeloUsuario(int Id)
        {
            try
            {
                var HorarioDoUsuario = _db.Usuario.FirstOrDefault(u => u.Id == Id);

                return new HorarioDTO
                {
                    Entrada = HorarioDoUsuario.Entrada,
                    Saida = HorarioDoUsuario.Saida
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Retonar Horario Registrado Pelo Usuario", ex.Message, ex.ToString());
                return null;
            }
        }

        public bool AtualizarHorarios(int Id, DateTime entrada, DateTime saida)
        {
            try
            {
                var usuario = _db.Usuario.FirstOrDefault(u => u.Id == Id);
                if (usuario == null)
                    return false;

                usuario.Entrada = entrada;
                usuario.Saida = saida;
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

        public bool AtualizarSenha(int Id, string senhaNova)
        {
            try
            {
                var usuarioAtual = _db.Usuario.FirstOrDefault(u => u.Id == Id);
                if (usuarioAtual == null)
                    return false;

                usuarioAtual.Senha = senhaNova;
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Atualizar senha", ex.Message, ex.ToString());
                return false;
            }
        }

        public string ObterSenhaAtual(int Id)
        {
            try
            {
                var usuarioAtual = _db.Usuario.FirstOrDefault(u => u.Id == Id);
                if (usuarioAtual == null)
                    return "";

                return usuarioAtual.Senha;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                _logErroService.Registrar("Obter senha", ex.Message, ex.ToString());
                return "";
            }
        }

    }
}
