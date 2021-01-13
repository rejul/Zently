namespace Zently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
