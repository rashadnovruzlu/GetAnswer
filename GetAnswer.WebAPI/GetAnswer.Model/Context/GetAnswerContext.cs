namespace GetAnswer.Model
{
    using System.Data.Entity;

    public partial class GetAnswerContext : DbContext
    {
        public GetAnswerContext()
            : base("name=GetAnswerContext")
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<DoctorateDegree> DoctorateDegrees { get; set; }
        public virtual DbSet<FileType> FileTypes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionAddition> QuestionAdditions { get; set; }
        public virtual DbSet<QuestionAttachmentFile> QuestionAttachmentFiles { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<UserInterestTag> UserInterestTags { get; set; }

        public virtual DbSet<VW_ALL_QUESTION> VW_ALL_QUESTION { get; set; }
        public virtual DbSet<VW_TAG> VW_TAG { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VW_TAG>()
             .Property(e => e.Type)
             .IsUnicode(false);


            modelBuilder.Entity<Answer>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Answer)
                .HasForeignKey(e => e.AnsweId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Answer>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Answer)
                .HasForeignKey(e => e.CorrectAnswerId);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.UserInterestTags)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<County>()
                .HasMany(e => e.Cities)
                .WithRequired(e => e.County)
                .HasForeignKey(e => e.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FileType>()
                .HasMany(e => e.QuestionAttachmentFiles)
                .WithRequired(e => e.FileType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Answers)
                .WithRequired(e => e.Question)
                .HasForeignKey(e => e.QuestionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.QuestionAttachmentFiles)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuestionAddition>()
                .HasOptional(e => e.Question)
                .WithRequired(e => e.QuestionAddition);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.UserInterestTags)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .HasOptional(e => e.AspNetUser)
                .WithRequired(e => e.UserInfo);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.TagList)
                .WithMany(e => e.Questions)
                .Map(m => m.ToTable("QuestionTag").MapLeftKey("QuestionId").MapRightKey("TagId"));
        }
    }
}

