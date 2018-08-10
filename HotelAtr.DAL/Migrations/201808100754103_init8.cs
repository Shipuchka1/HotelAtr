namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Room", "RoomType_RoomTypeId", "dbo.RoomType");
            DropIndex("dbo.Room", new[] { "RoomType_RoomTypeId" });
            RenameColumn(table: "dbo.Room", name: "RoomType_RoomTypeId", newName: "RoomTypeId");
            AlterColumn("dbo.Room", "RoomTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Room", "RoomTypeId");
            AddForeignKey("dbo.Room", "RoomTypeId", "dbo.RoomType", "RoomTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Room", "RoomTypeId", "dbo.RoomType");
            DropIndex("dbo.Room", new[] { "RoomTypeId" });
            AlterColumn("dbo.Room", "RoomTypeId", c => c.Int());
            RenameColumn(table: "dbo.Room", name: "RoomTypeId", newName: "RoomType_RoomTypeId");
            CreateIndex("dbo.Room", "RoomType_RoomTypeId");
            AddForeignKey("dbo.Room", "RoomType_RoomTypeId", "dbo.RoomType", "RoomTypeId");
        }
    }
}
