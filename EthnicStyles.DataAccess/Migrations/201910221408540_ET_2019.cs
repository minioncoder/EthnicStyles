namespace EthnicStyles.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ET_2019 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCatId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ProductCatId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ItemName = c.String(),
                        Price = c.Int(nullable: false),
                        ProdCategoryId_ProductCatId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.ProductCategories", t => t.ProdCategoryId_ProductCatId)
                .Index(t => t.ProdCategoryId_ProductCatId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailId = c.String(),
                        RoleId_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Roles", t => t.RoleId_RoleId)
                .Index(t => t.RoleId_RoleId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleId = c.Int(nullable: false, identity: true),
                        RoleId_RoleId = c.Int(),
                        UserId_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.UserRoleId)
                .ForeignKey("dbo.Roles", t => t.RoleId_RoleId)
                .ForeignKey("dbo.Users", t => t.UserId_UserID)
                .Index(t => t.RoleId_RoleId)
                .Index(t => t.UserId_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "UserId_UserID", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId_RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "RoleId_RoleId", "dbo.Roles");
            DropForeignKey("dbo.Products", "ProdCategoryId_ProductCatId", "dbo.ProductCategories");
            DropIndex("dbo.UserRoles", new[] { "UserId_UserID" });
            DropIndex("dbo.UserRoles", new[] { "RoleId_RoleId" });
            DropIndex("dbo.Users", new[] { "RoleId_RoleId" });
            DropIndex("dbo.Products", new[] { "ProdCategoryId_ProductCatId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
        }
    }
}
