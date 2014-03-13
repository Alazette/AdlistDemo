namespace GreggsListData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Name = c.String(),
                        DateListed = c.DateTime(nullable: false),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RegionId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactMessages", "UserId", "dbo.Users");
            DropForeignKey("dbo.Items", "UserId", "dbo.Users");
            DropForeignKey("dbo.Regions", "StateId", "dbo.States");
            DropForeignKey("dbo.Items", "RegionId", "dbo.Regions");
            DropIndex("dbo.ContactMessages", new[] { "UserId" });
            DropIndex("dbo.Items", new[] { "UserId" });
            DropIndex("dbo.Regions", new[] { "StateId" });
            DropIndex("dbo.Items", new[] { "RegionId" });
            DropTable("dbo.States");
            DropTable("dbo.Regions");
            DropTable("dbo.Items");
            DropTable("dbo.Users");
            DropTable("dbo.ContactMessages");
        }
    }
}
