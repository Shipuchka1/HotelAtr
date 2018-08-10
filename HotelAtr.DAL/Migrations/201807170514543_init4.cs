namespace HotelAtr.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        Description = c.String(maxLength: 250),
                        PathImg = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
        }
    }
}
