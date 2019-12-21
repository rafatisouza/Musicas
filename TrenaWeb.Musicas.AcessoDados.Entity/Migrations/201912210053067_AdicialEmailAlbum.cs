namespace TrenaWeb.Musicas.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicialEmailAlbum : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Albuns", newSchema: "Cronos");
            AddColumn("Cronos.Albuns", "EMAIL", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("Cronos.Albuns", "EMAIL");
            MoveTable(name: "Cronos.Albuns", newSchema: "dbo");
        }
    }
}
