namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Name", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Name", c => c.String(maxLength: 250));
        }
    }
}
