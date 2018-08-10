namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoomType", "Description", c => c.String(maxLength: 250));
            AddColumn("dbo.RoomType", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoomType", "Cost");
            DropColumn("dbo.RoomType", "Description");
        }
    }
}
