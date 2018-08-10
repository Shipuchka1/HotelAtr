namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RoomType", "Name", c => c.String(maxLength: 250));
            DropColumn("dbo.RoomType", "Description");
            DropColumn("dbo.RoomType", "Cost");
            DropColumn("dbo.RoomType", "PathImg");
            DropTable("dbo.Services");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Description = c.String(maxLength: 250),
                        PathImg = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ServicesId);
            
            AddColumn("dbo.RoomType", "PathImg", c => c.String(maxLength: 250));
            AddColumn("dbo.RoomType", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.RoomType", "Description", c => c.String(maxLength: 250));
            AlterColumn("dbo.RoomType", "Name", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
