namespace RSH.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplyDate = c.DateTime(nullable: false),
                        ApplyMethod = c.String(),
                        Description = c.String(),
                        PersonID = c.Int(nullable: false),
                        ResumeID = c.Int(nullable: false),
                        CoverLetterID = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.CoverLetters", t => t.CoverLetterID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .ForeignKey("dbo.Resumes", t => t.ResumeID, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusID, cascadeDelete: true)
                .Index(t => t.PersonID)
                .Index(t => t.ResumeID)
                .Index(t => t.CoverLetterID)
                .Index(t => t.CompanyID)
                .Index(t => t.StatusID)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Tel = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Other = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoverLetters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CoverLetter_Url = c.String(),
                        UploadDate = c.DateTime(nullable: false),
                        PersonID = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.People", t => t.PersonID)
                .Index(t => t.PersonID)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Mobile = c.String(nullable: false, maxLength: 15),
                        EmergancyPhone = c.String(maxLength: 15),
                        ResumeUrl = c.String(),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InterviewDate = c.DateTime(nullable: false),
                        InterviewBy = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        ApplyID = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Applies", t => t.ApplyID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.ApplyID)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Resume_Url = c.String(),
                        UploadDate = c.DateTime(nullable: false),
                        PersonID = c.Int(nullable: false),
                        Person_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonID)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.PersonID)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Templates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TemplateBody = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applies", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Applies", "ResumeID", "dbo.Resumes");
            DropForeignKey("dbo.Applies", "PersonID", "dbo.People");
            DropForeignKey("dbo.Applies", "CoverLetterID", "dbo.CoverLetters");
            DropForeignKey("dbo.CoverLetters", "PersonID", "dbo.People");
            DropForeignKey("dbo.Resumes", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Resumes", "PersonID", "dbo.People");
            DropForeignKey("dbo.Interviews", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Interviews", "ApplyID", "dbo.Applies");
            DropForeignKey("dbo.CoverLetters", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Applies", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Applies", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Resumes", new[] { "Person_Id" });
            DropIndex("dbo.Resumes", new[] { "PersonID" });
            DropIndex("dbo.Interviews", new[] { "Person_Id" });
            DropIndex("dbo.Interviews", new[] { "ApplyID" });
            DropIndex("dbo.People", new[] { "Email" });
            DropIndex("dbo.CoverLetters", new[] { "Person_Id" });
            DropIndex("dbo.CoverLetters", new[] { "PersonID" });
            DropIndex("dbo.Applies", new[] { "Person_Id" });
            DropIndex("dbo.Applies", new[] { "StatusID" });
            DropIndex("dbo.Applies", new[] { "CompanyID" });
            DropIndex("dbo.Applies", new[] { "CoverLetterID" });
            DropIndex("dbo.Applies", new[] { "ResumeID" });
            DropIndex("dbo.Applies", new[] { "PersonID" });
            DropTable("dbo.Templates");
            DropTable("dbo.Status");
            DropTable("dbo.Resumes");
            DropTable("dbo.Interviews");
            DropTable("dbo.People");
            DropTable("dbo.CoverLetters");
            DropTable("dbo.Companies");
            DropTable("dbo.Applies");
        }
    }
}
