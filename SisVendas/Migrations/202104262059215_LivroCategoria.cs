namespace SisVendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LivroCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Autor = c.String(),
                        AnoEdicao = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GeneroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genero", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.GeneroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livro", "GeneroId", "dbo.Genero");
            DropIndex("dbo.Livro", new[] { "GeneroId" });
            DropTable("dbo.Livro");
            DropTable("dbo.Genero");
        }
    }
}
