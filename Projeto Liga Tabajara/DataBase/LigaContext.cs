using Projeto_Liga_Tabajara.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto_Liga_Tabajara.DataBase
{
    public class LigaContext : DbContext
    {
        public LigaContext() : base("LigaContext")
        {

        }
        public DbSet<Liga> Ligas { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<ComissaoTecnica> ComissoesTecnicas { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<Estatistica> Estatisticas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeMandante)
                .WithMany()
                .HasForeignKey(p => p.TimeMandanteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeVisitante)
                .WithMany()
                .HasForeignKey(p => p.TimeVisitanteId)
                .WillCascadeOnDelete(false);
        }
    }

}