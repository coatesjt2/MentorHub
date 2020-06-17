namespace MentorHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToSessions : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Sessions", name: "Mentor_Id", newName: "MentorId");
            RenameColumn(table: "dbo.Sessions", name: "Occupations_Id", newName: "OccupationsId");
            RenameIndex(table: "dbo.Sessions", name: "IX_Mentor_Id", newName: "IX_MentorId");
            RenameIndex(table: "dbo.Sessions", name: "IX_Occupations_Id", newName: "IX_OccupationsId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Sessions", name: "IX_OccupationsId", newName: "IX_Occupations_Id");
            RenameIndex(table: "dbo.Sessions", name: "IX_MentorId", newName: "IX_Mentor_Id");
            RenameColumn(table: "dbo.Sessions", name: "OccupationsId", newName: "Occupations_Id");
            RenameColumn(table: "dbo.Sessions", name: "MentorId", newName: "Mentor_Id");
        }
    }
}
