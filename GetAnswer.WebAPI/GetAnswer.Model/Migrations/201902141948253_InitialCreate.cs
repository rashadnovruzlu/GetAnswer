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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        CityName = c.String(nullable: false, maxLength: 100),
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
                .PrimaryKey(t => t.Id);
            
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
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FileType",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Extension = c.String(nullable: false, maxLength: 10),
                        MIMEType = c.String(nullable: false, maxLength: 200),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Tags = c.String(nullable: false, maxLength: 250),
                        Title = c.String(nullable: false, maxLength: 500),
                        Body = c.String(nullable: false),
                        CorrectAnswerId = c.Int(),
                        ViewCount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
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
                .PrimaryKey(t => t.UserId);
            
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
                .PrimaryKey(t => t.Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.UserInterestTag");
            DropTable("dbo.UserInfo");
            DropTable("dbo.Tag");
            DropTable("dbo.RefreshTokens");
            DropTable("dbo.QuestionAttachmentFile");
            DropTable("dbo.QuestionAddition");
            DropTable("dbo.Question");
            DropTable("dbo.FileType");
            DropTable("dbo.DoctorateDegree");
            DropTable("dbo.County");
            DropTable("dbo.Comment");
            DropTable("dbo.Clients");
            DropTable("dbo.City");
            DropTable("dbo.Category");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Answer");
        }
    }
}
