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
        public MusicasDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }   
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
            //Definir schema
            modelBuilder.HasDefaultSchema("Cronos");
        }
        public DbSet<Album> Albuns { get; set; }

    }
}
