namespace Projeto_Liga_Tabajara.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComissaoTecnicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cargo = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeId, cascadeDelete: true)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        AnoFundacao = c.DateTime(nullable: false),
                        Estadio = c.String(),
                        CapacidadeEstadio = c.Int(nullable: false),
                        CorUniformePrimaria = c.String(),
                        CorUniformeSecundaria = c.String(),
                        Status = c.Boolean(nullable: false),
                        Liga_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ligas", t => t.Liga_Id)
                .Index(t => t.Liga_Id);
            
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Nacionalidade = c.String(),
                        Posicao = c.Int(nullable: false),
                        NumeroCamisa = c.Int(nullable: false),
                        Altura = c.Double(nullable: false),
                        Peso = c.Double(nullable: false),
                        PePreferido = c.Int(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeId, cascadeDelete: true)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Estatisticas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JogadorId = c.Int(nullable: false),
                        PartidaId = c.Int(nullable: false),
                        Gols = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jogadors", t => t.JogadorId, cascadeDelete: true)
                .ForeignKey("dbo.Partidas", t => t.PartidaId, cascadeDelete: true)
                .Index(t => t.JogadorId)
                .Index(t => t.PartidaId);
            
            CreateTable(
                "dbo.Partidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Rodada = c.Int(nullable: false),
                        Estadio = c.String(),
                        TimeMandanteId = c.Int(nullable: false),
                        TimeVisitanteId = c.Int(nullable: false),
                        GolsMandante = c.Int(nullable: false),
                        GolsVisitante = c.Int(nullable: false),
                        Resultado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeMandanteId)
                .ForeignKey("dbo.Times", t => t.TimeVisitanteId)
                .Index(t => t.TimeMandanteId)
                .Index(t => t.TimeVisitanteId);
            
            CreateTable(
                "dbo.Ligas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Times", "Liga_Id", "dbo.Ligas");
            DropForeignKey("dbo.Partidas", "TimeVisitanteId", "dbo.Times");
            DropForeignKey("dbo.Partidas", "TimeMandanteId", "dbo.Times");
            DropForeignKey("dbo.Estatisticas", "PartidaId", "dbo.Partidas");
            DropForeignKey("dbo.Estatisticas", "JogadorId", "dbo.Jogadors");
            DropForeignKey("dbo.Jogadors", "TimeId", "dbo.Times");
            DropForeignKey("dbo.ComissaoTecnicas", "TimeId", "dbo.Times");
            DropIndex("dbo.Partidas", new[] { "TimeVisitanteId" });
            DropIndex("dbo.Partidas", new[] { "TimeMandanteId" });
            DropIndex("dbo.Estatisticas", new[] { "PartidaId" });
            DropIndex("dbo.Estatisticas", new[] { "JogadorId" });
            DropIndex("dbo.Jogadors", new[] { "TimeId" });
            DropIndex("dbo.Times", new[] { "Liga_Id" });
            DropIndex("dbo.ComissaoTecnicas", new[] { "TimeId" });
            DropTable("dbo.Ligas");
            DropTable("dbo.Partidas");
            DropTable("dbo.Estatisticas");
            DropTable("dbo.Jogadors");
            DropTable("dbo.Times");
            DropTable("dbo.ComissaoTecnicas");
        }
    }
}
