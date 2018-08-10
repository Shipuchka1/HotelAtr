namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoomType", "IsFreeWiFi", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoomType", "isPrivateBalcony", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoomType", "isFullAC", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoomType", "HasTV", c => c.Boolean(nullable: false));
            AddColumn("dbo.RoomType", "isBeachView", c => c.Boolean(nullable: false));
            DropColumn("dbo.Room", "IsFreeWiFi");
            DropColumn("dbo.Room", "isPrivateBalcony");
            DropColumn("dbo.Room", "isFullAC");
            DropColumn("dbo.Room", "HasTV");
            DropColumn("dbo.Room", "isBeachView");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Room", "isBeachView", c => c.Boolean(nullable: false));
            AddColumn("dbo.Room", "HasTV", c => c.Boolean(nullable: false));
            AddColumn("dbo.Room", "isFullAC", c => c.Boolean(nullable: false));
            AddColumn("dbo.Room", "isPrivateBalcony", c => c.Boolean(nullable: false));
            AddColumn("dbo.Room", "IsFreeWiFi", c => c.Boolean(nullable: false));
            DropColumn("dbo.RoomType", "isBeachView");
            DropColumn("dbo.RoomType", "HasTV");
            DropColumn("dbo.RoomType", "isFullAC");
            DropColumn("dbo.RoomType", "isPrivateBalcony");
            DropColumn("dbo.RoomType", "IsFreeWiFi");
        }
    }
}
