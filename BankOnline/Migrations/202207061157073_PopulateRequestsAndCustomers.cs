namespace BankOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRequestsAndCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, Gender, JMBG, IdCardRegNumber, Adress, BirthDate, Employer, TypeOfEmployment, DateOfEmployment) VALUES ('Nebojsa Balan', 'Male', '0703996870201', '009687469', 'Blagoja Parovica 9a', '03-07-1996', '', 'Student', '' )");
            Sql("INSERT INTO Customers (Name, Gender, JMBG, IdCardRegNumber, Adress, BirthDate, Employer, TypeOfEmployment, DateOfEmployment) VALUES ('Aleksandra Vrkatic', 'Female', '2008996875206', '008687369', 'Mise Dimitrijevica 3c', '08-20-1996', 'Medicinski fakultet', 'Full Time', '08-08-2020' )");

            Sql("INSERT INTO Requests (DateOfApplication, RequestStatus, Commentary, Card_Id) VALUES ('06-07-2022', 'Pending', '', 8)");
            Sql("INSERT INTO Requests (DateOfApplication, RequestStatus, Commentary, Card_Id) VALUES ('06-07-2022', 'Pending', '', 1)");

            
        }
        
        public override void Down()
        {
        }
    }
}
