namespace ProductService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "Address_Street", c => c.String());
            AddColumn("dbo.Suppliers", "Address_ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "Address_ZipCode");
            DropColumn("dbo.Suppliers", "Address_Street");
        }
    }
}
