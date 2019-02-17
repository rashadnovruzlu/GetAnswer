namespace GetAnswer.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Body = c.String(nullable: false),
                        UsefulCount = c.Int(nullable: false),
                        NotUsefulCount = c.Int(nullable: false),
                        IsCorrectAnswer = c.Byte(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnsweId = c.Int(nullable: false),
                        Comment = c.String(nullable: false),
                        ReadDate = c.DateTime(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answer", t => t.AnsweId)
                .Index(t => t.AnsweId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Tags = c.String(nullable: false, maxLength: 250),
                        Title = c.String(nullable: false, maxLength: 500),
                        Body = c.String(nullable: false),
                        CorrectAnswerId = c.Int(),
                        ViewCount = c.Int(nullable: false),
                        UsefulCount = c.Int(nullable: false),
                        NotUsefulCount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .ForeignKey("dbo.QuestionAddition", t => t.Id)
                .ForeignKey("dbo.Answer", t => t.CorrectAnswerId)
                .Index(t => t.Id)
                .Index(t => t.CategoryId)
                .Index(t => t.CorrectAnswerId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuestionAddition",
                c => new
                    {
                        QuestionId = c.Int(nullable: false),
                        AnswerSendEmail = c.Boolean(nullable: false),
                        AnswerSendPhone = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            CreateTable(
                "dbo.QuestionAttachmentFile",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        FileName = c.String(nullable: false, maxLength: 125),
                        FileTypeId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FileType", t => t.FileTypeId)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .Index(t => t.QuestionId)
                .Index(t => t.FileTypeId);
            
            CreateTable(
                "dbo.FileType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Extension = c.String(nullable: false, maxLength: 10),
                        MIMEType = c.String(nullable: false, maxLength: 200),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Tag = c.String(nullable: false, maxLength: 50),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInterestTag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TagId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .ForeignKey("dbo.Tag", t => t.TagId)
                .Index(t => t.TagId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Level = c.Byte(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInfo", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        DoctorateDegreeId = c.Byte(),
                        CityId = c.Int(),
                        Phone = c.String(maxLength: 100),
                        Base64Image = c.String(),
                        About = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.City", t => t.CityId)
                .ForeignKey("dbo.DoctorateDegree", t => t.DoctorateDegreeId)
                .Index(t => t.DoctorateDegreeId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        CityName = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.County", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.County",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 200),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DoctorateDegree",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Secret = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        ApplicationType = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        RefreshTokenLifeTime = c.Int(nullable: false),
                        AllowedOrigin = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RefreshTokens",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Subject = c.String(nullable: false, maxLength: 50),
                        ClientId = c.String(nullable: false, maxLength: 50),
                        IssuedUtc = c.DateTime(nullable: false),
                        ExpiresUtc = c.DateTime(nullable: false),
                        ProtectedTicket = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VW_ALL_QUESTION",
                c => new
                    {
                        QuestionId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 500),
                        Body = c.String(nullable: false, maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        CategoryId = c.Int(nullable: false),
                        Category = c.String(nullable: false, maxLength: 100),
                        AnswerCount = c.Int(),
                        Votes = c.Int(),
                        UserImage = c.String(),
                        CorrectAnswerId = c.Int(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => new { t.QuestionId, t.Title, t.Body, t.CreatedDate, t.ViewCount, t.UserName, t.CategoryId, t.Category });
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.QuestionTag",
                c => new
                    {
                        QuestionId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.QuestionId, t.TagId })
                .ForeignKey("dbo.Question", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.TagId, cascadeDelete: true)
                .Index(t => t.QuestionId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Question", "CorrectAnswerId", "dbo.Answer");
            DropForeignKey("dbo.QuestionTag", "TagId", "dbo.Tag");
            DropForeignKey("dbo.QuestionTag", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.UserInterestTag", "TagId", "dbo.Tag");
            DropForeignKey("dbo.UserInterestTag", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserInfo", "DoctorateDegreeId", "dbo.DoctorateDegree");
            DropForeignKey("dbo.UserInfo", "CityId", "dbo.City");
            DropForeignKey("dbo.City", "CountryId", "dbo.County");
            DropForeignKey("dbo.AspNetUsers", "Id", "dbo.UserInfo");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.QuestionAttachmentFile", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.QuestionAttachmentFile", "FileTypeId", "dbo.FileType");
            DropForeignKey("dbo.Question", "Id", "dbo.QuestionAddition");
            DropForeignKey("dbo.Question", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Answer", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.Comment", "AnsweId", "dbo.Answer");
            DropIndex("dbo.QuestionTag", new[] { "TagId" });
            DropIndex("dbo.QuestionTag", new[] { "QuestionId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.City", new[] { "CountryId" });
            DropIndex("dbo.UserInfo", new[] { "CityId" });
            DropIndex("dbo.UserInfo", new[] { "DoctorateDegreeId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Id" });
            DropIndex("dbo.UserInterestTag", new[] { "UserId" });
            DropIndex("dbo.UserInterestTag", new[] { "TagId" });
            DropIndex("dbo.QuestionAttachmentFile", new[] { "FileTypeId" });
            DropIndex("dbo.QuestionAttachmentFile", new[] { "QuestionId" });
            DropIndex("dbo.Question", new[] { "CorrectAnswerId" });
            DropIndex("dbo.Question", new[] { "CategoryId" });
            DropIndex("dbo.Question", new[] { "Id" });
            DropIndex("dbo.Comment", new[] { "AnsweId" });
            DropIndex("dbo.Answer", new[] { "QuestionId" });
            DropTable("dbo.QuestionTag");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.VW_ALL_QUESTION");
            DropTable("dbo.RefreshTokens");
            DropTable("dbo.Clients");
            DropTable("dbo.DoctorateDegree");
            DropTable("dbo.County");
            DropTable("dbo.City");
            DropTable("dbo.UserInfo");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UserInterestTag");
            DropTable("dbo.Tag");
            DropTable("dbo.FileType");
            DropTable("dbo.QuestionAttachmentFile");
            DropTable("dbo.QuestionAddition");
            DropTable("dbo.Category");
            DropTable("dbo.Question");
            DropTable("dbo.Comment");
            DropTable("dbo.Answer");
        }
    }
}
