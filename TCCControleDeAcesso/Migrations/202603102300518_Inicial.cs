namespace TCCControleDeAcesso.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadastroAlunos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        rm = c.String(unicode: false),
                        serie = c.String(unicode: false),
                        idade = c.String(unicode: false),
                        idArduino = c.Int(nullable: false),
                        idEscola = c.Int(nullable: false),
                        NomeCurso = c.String(unicode: false),
                        foto = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        idEscola = c.Int(nullable: false),
                        Escola_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Escolas", t => t.Escola_Id)
                .Index(t => t.Escola_Id);
            
            CreateTable(
                "dbo.Escolas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Entradas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idAluno = c.Int(nullable: false),
                        nome = c.String(unicode: false),
                        dataEntrada = c.String(unicode: false),
                        idEscola = c.Int(nullable: false),
                        Escola_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Escolas", t => t.Escola_Id)
                .Index(t => t.Escola_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entradas", "Escola_Id", "dbo.Escolas");
            DropForeignKey("dbo.Cursoes", "Escola_Id", "dbo.Escolas");
            DropIndex("dbo.Entradas", new[] { "Escola_Id" });
            DropIndex("dbo.Cursoes", new[] { "Escola_Id" });
            DropTable("dbo.Entradas");
            DropTable("dbo.Escolas");
            DropTable("dbo.Cursoes");
            DropTable("dbo.CadastroAlunos");
        }
    }
}
