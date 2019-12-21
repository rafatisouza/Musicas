namespace TrenaWeb.Musicas.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albuns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NOME = c.String(nullable: false, maxLength: 100),
                        ANO = c.Int(nullable: false),
                        OBSERVACOES = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Albuns");
        }
    }
}
