namespace BankOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAnnotationsToModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Cards", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.TypeOfCards", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Gender", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Customers", "JMBG", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("dbo.Customers", "IdCardRegNumber", c => c.String(nullable: false, maxLength: 9));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "IdCardRegNumber", c => c.String());
            AlterColumn("dbo.Customers", "JMBG", c => c.String());
            AlterColumn("dbo.Customers", "Gender", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.TypeOfCards", "Name", c => c.String());
            AlterColumn("dbo.Cards", "Name", c => c.String());
            AlterColumn("dbo.Brands", "Name", c => c.String());
        }
    }
}
