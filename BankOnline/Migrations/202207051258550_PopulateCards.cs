namespace BankOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCards : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Green', 3600, 2.42, 1, 1)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Gold', 6600, 0.60, 1, 1)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Standard', 2400, 2.13, 2, 1)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Platinum', 40, 1.87, 2, 1)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Gold', 50, 1.10, 2, 1)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Classic', 2400, 2.13, 3, 1)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Gold', 6600, 1.10, 3, 1)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Standard', 0, 0, 2, 2)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Inspire', 0, 0, 3, 2)");
            Sql("INSERT INTO Cards (Name, MaintenanceFee, EffectiveNominalRate, Brand_Id, TypeOfCard_Id) VALUES ('Classic', 0, 0, 4, 2)");
            

        }
        
        public override void Down()
        {
        }
    }
}
