namespace _11_RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingvirtualrestaurant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "DateCreated");
        }
    }
}
