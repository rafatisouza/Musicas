namespace TrenaWeb.Musicas.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrenaWeb.Musicas.AcessoDados.Entity.Context;

    internal sealed class Configuration : DbMigrationsConfiguration<TrenaWeb.Musicas.AcessoDados.Entity.Context.MusicasDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrenaWeb.Musicas.AcessoDados.Entity.Context.MusicasDbContext context)
        {
      
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
