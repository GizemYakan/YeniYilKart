namespace YeniYilKart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kartlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(nullable: false),
                        AliciAd = c.String(nullable: false),
                        GondericiAd = c.String(),
                        Mesaj = c.String(),
                        ResimAd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kartlar");
        }
    }
}
