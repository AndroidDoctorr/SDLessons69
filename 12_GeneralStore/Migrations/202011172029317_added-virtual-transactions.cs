namespace _12_GeneralStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvirtualtransactions : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Transactions", "CustomerID");
            AddForeignKey("dbo.Transactions", "CustomerID", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "CustomerID" });
        }
    }
}
