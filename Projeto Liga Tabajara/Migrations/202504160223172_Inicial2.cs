namespace Projeto_Liga_Tabajara.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Times", "Liga_Id", "dbo.Ligas");
            DropIndex("dbo.Times", new[] { "Liga_Id" });
            RenameColumn(table: "dbo.Times", name: "Liga_Id", newName: "LigaId");
            AlterColumn("dbo.Times", "LigaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Times", "LigaId");
            AddForeignKey("dbo.Times", "LigaId", "dbo.Ligas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Times", "LigaId", "dbo.Ligas");
            DropIndex("dbo.Times", new[] { "LigaId" });
            AlterColumn("dbo.Times", "LigaId", c => c.Int());
            RenameColumn(table: "dbo.Times", name: "LigaId", newName: "Liga_Id");
            CreateIndex("dbo.Times", "Liga_Id");
            AddForeignKey("dbo.Times", "Liga_Id", "dbo.Ligas", "Id");
        }
    }
}
