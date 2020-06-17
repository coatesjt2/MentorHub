namespace MentorHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOccupationTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Occupations (Id, Name) VALUES (1, 'Physician')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (2, 'Dentist')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (3, 'Nurse')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (4, 'Nurse Practioner')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (5, 'Software Developer')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (6, 'Administrator')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (7, 'Veterinarian')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (8, 'Minister')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (9, 'IT Manager')");
            Sql("INSERT INTO Occupations (Id, Name) VALUES (10, 'System Engineer')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Occupations WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10)");
        }
    }
}
