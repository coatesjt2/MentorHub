namespace MentorHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSessionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Occupations",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Mentor_Id = c.String(maxLength: 128),
                        Occupations_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Mentor_Id)
                .ForeignKey("dbo.Occupations", t => t.Occupations_Id)
                .Index(t => t.Mentor_Id)
                .Index(t => t.Occupations_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "Occupations_Id", "dbo.Occupations");
            DropForeignKey("dbo.Sessions", "Mentor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Sessions", new[] { "Occupations_Id" });
            DropIndex("dbo.Sessions", new[] { "Mentor_Id" });
            DropTable("dbo.Sessions");
            DropTable("dbo.Occupations");
        }
    }
}
