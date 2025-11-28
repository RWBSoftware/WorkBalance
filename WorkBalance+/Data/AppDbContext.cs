using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WorkBalance_.Model;

namespace WorkBalance_.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string _db;
        public AppDbContext()
        {
            _db = Path.Combine(@"C:\Projetos\WorkBalance+\WorkBalance+\Data", "WorkBalance.db");
        }

        public AppDbContext(string db)
        {
            _db = db;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={_db}");

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<HorarioModel> Horario { get; set; }
    }
}
