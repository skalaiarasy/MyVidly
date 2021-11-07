namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name) Values('Tharunika')");
            Sql("INSERT INTO Customers(Name) Values('Madhunika')");
            Sql("INSERT INTO Customers(Name) Values('Sonia')");
        }
        
        public override void Down()
        {
        }
    }
}
