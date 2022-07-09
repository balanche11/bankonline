namespace BankOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        JMBG = c.String(),
                        IdCardRegNumber = c.String(),
                        Adress = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Employer = c.String(),
                        TypeOfEmployment = c.String(),
                        DateOfEmployment = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfApplication = c.DateTime(nullable: false),
                        RequestStatus = c.String(),
                        Commentary = c.String(),
                        Card_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.Card_Id)
                .Index(t => t.Card_Id);
            
            CreateTable(
                "dbo.RequestCustomers",
                c => new
                    {
                        Request_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Request_Id, t.Customer_Id })
                .ForeignKey("dbo.Requests", t => t.Request_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Request_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequestCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.RequestCustomers", "Request_Id", "dbo.Requests");
            DropForeignKey("dbo.Requests", "Card_Id", "dbo.Cards");
            DropIndex("dbo.RequestCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.RequestCustomers", new[] { "Request_Id" });
            DropIndex("dbo.Requests", new[] { "Card_Id" });
            DropTable("dbo.RequestCustomers");
            DropTable("dbo.Requests");
            DropTable("dbo.Customers");
        }
    }
}
