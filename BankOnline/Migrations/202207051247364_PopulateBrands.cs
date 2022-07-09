namespace BankOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBrands : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Brands (Name) VALUES ('American Express')");
            Sql("INSERT INTO Brands (Name) VALUES ('MasterCard')");
            Sql("INSERT INTO Brands (Name) VALUES ('Visa')");
        }
        
        public override void Down()
        {
        }
    }
}
