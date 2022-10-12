namespace ProjF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnoCampeonato : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipes", "UltimoAnoCampeao", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipes", "UltimoAnoCampeao");
        }
    }
}
