namespace FarukHamburger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HamburgerInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extralar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExtraAdi = c.String(nullable: false),
                        Fiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiparisExtras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiparisId = c.Int(nullable: false),
                        ExtraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Extralar", t => t.ExtraId, cascadeDelete: true)
                .ForeignKey("dbo.Siparisler", t => t.SiparisId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.ExtraId);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        Boyutu = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        ToplamTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menuler", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Menuler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuAdi = c.String(nullable: false),
                        Fiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisExtras", "SiparisId", "dbo.Siparisler");
            DropForeignKey("dbo.Siparisler", "MenuId", "dbo.Menuler");
            DropForeignKey("dbo.SiparisExtras", "ExtraId", "dbo.Extralar");
            DropIndex("dbo.Siparisler", new[] { "MenuId" });
            DropIndex("dbo.SiparisExtras", new[] { "ExtraId" });
            DropIndex("dbo.SiparisExtras", new[] { "SiparisId" });
            DropTable("dbo.Menuler");
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisExtras");
            DropTable("dbo.Extralar");
        }
    }
}
