namespace _12_GeneralStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedforeignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "CustomerID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Transactions", "CustomerID");
            AddForeignKey("dbo.Transactions", "CustomerID", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
