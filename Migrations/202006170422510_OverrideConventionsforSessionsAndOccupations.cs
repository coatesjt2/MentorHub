namespace MentorHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsforSessionsAndOccupations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sessions", "Mentor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Sessions", "Occupations_Id", "dbo.Occupations");
            DropIndex("dbo.Sessions", new[] { "Mentor_Id" });
            DropIndex("dbo.Sessions", new[] { "Occupations_Id" });
            AlterColumn("dbo.Occupations", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Sessions", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Sessions", "Mentor_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Sessions", "Occupations_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Sessions", "Mentor_Id");
            CreateIndex("dbo.Sessions", "Occupations_Id");
            AddForeignKey("dbo.Sessions", "Mentor_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sessions", "Occupations_Id", "dbo.Occupations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "Occupations_Id", "dbo.Occupations");
            DropForeignKey("dbo.Sessions", "Mentor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Sessions", new[] { "Occupations_Id" });
            DropIndex("dbo.Sessions", new[] { "Mentor_Id" });
            AlterColumn("dbo.Sessions", "Occupations_Id", c => c.Byte());
            AlterColumn("dbo.Sessions", "Mentor_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Sessions", "Venue", c => c.String());
            AlterColumn("dbo.Occupations", "Name", c => c.String());
            CreateIndex("dbo.Sessions", "Occupations_Id");
            CreateIndex("dbo.Sessions", "Mentor_Id");
            AddForeignKey("dbo.Sessions", "Occupations_Id", "dbo.Occupations", "Id");
            AddForeignKey("dbo.Sessions", "Mentor_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
