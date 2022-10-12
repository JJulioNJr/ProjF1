namespace ProjF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EquipeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipes", t => t.EquipeId, cascadeDelete: true)
                .Index(t => t.EquipeId);
            
            CreateTable(
                "dbo.Equipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carroes", "EquipeId", "dbo.Equipes");
            DropIndex("dbo.Carroes", new[] { "EquipeId" });
            DropTable("dbo.Equipes");
            DropTable("dbo.Carroes");
        }
    }
}
