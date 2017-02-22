namespace Vidly_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAdd1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Vlado Vranjkovic', 0, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
