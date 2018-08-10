namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Service", newName: "Services");
            AlterColumn("dbo.RoomType", "Name", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RoomType", "Name", c => c.String(nullable: false, maxLength: 250));
            RenameTable(name: "dbo.Services", newName: "Service");
        }
    }
}
