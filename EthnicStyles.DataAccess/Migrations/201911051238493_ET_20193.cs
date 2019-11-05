namespace EthnicStyles.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ET_20193 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductCategoryId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductCategoryId");
        }
    }
}
