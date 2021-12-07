using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class LabContext : DbContext
    {

        public DbSet<SolicitacaoModel> solicitacaos { get; set; }
        public DbSet<AgendamentoModel> agendamentos { get; set; }
        public DbSet<ContatoModel> contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server =192.168.0.104;Database=postgres;User id =postgres;Password=74269;Persist Security Info=True");

        }

    }
}
