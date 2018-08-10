namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Room", "RoomType_RoomTypeId", c => c.Int());
            CreateIndex("dbo.Room", "RoomType_RoomTypeId");
            AddForeignKey("dbo.Room", "RoomType_RoomTypeId", "dbo.RoomType", "RoomTypeId");
            DropColumn("dbo.Room", "TypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Room", "TypeId", c => c.Int());
            DropForeignKey("dbo.Room", "RoomType_RoomTypeId", "dbo.RoomType");
            DropIndex("dbo.Room", new[] { "RoomType_RoomTypeId" });
            DropColumn("dbo.Room", "RoomType_RoomTypeId");
        }
    }
}
