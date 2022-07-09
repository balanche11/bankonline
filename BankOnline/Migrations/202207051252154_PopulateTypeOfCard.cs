namespace BankOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypeOfCard : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TypeOfCards (Name) VALUES ('Credit')");
            Sql("INSERT INTO TypeOfCards (Name) VALUES ('Debit')");
        }
        
        public override void Down()
        {
        }
    }
}
