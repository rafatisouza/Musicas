using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Musicas.Dominio;
using TrenaWeb.Musicas.AcessoDados.Entity.TypeConfiguration;

namespace TrenaWeb.Musicas.AcessoDados.Entity.Context
{
    public class MusicasDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
        }
        public DbSet<Album> Albuns { get; set; }

    }
}
