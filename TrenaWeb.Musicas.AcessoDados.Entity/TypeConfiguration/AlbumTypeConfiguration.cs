using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Comum.Entity;
using TreinaWeb.Musicas.Dominio;

namespace TrenaWeb.Musicas.AcessoDados.Entity.TypeConfiguration
{
    internal class AlbumTypeConfiguration : TreinaWebEntityConfig<Album>
    {
        protected override void ConfigurarCampo()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ID");
            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("NOME")
                .HasMaxLength(100);
            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("ANO");
            Property(p => p.Observacoes)
                .IsOptional()
                .HasColumnName("OBSERVACOES")
                .HasMaxLength(1000);
            Property(p => p.Email)
                .IsRequired()
                .HasColumnName("EMAIL")
                .HasMaxLength(50);
            
        }

        protected override void ConfigurarFK()
        {
            
        }

        protected override void ConfigurarNome()
        {
            ToTable("Albuns");
        }

        protected override void ConfigurarPK()
        {
            HasKey(pk => pk.Id);
        }
    }
}
