namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RoomType", "PathImg", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RoomType", "PathImg");
        }
    }
}
