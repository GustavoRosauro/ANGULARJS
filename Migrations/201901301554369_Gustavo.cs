namespace PraticandoAngular.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gustavo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carroes");
        }
    }
}
