namespace GetAnswer.Model
{
    using System.Data.Entity;

    public partial class GetAnswerModel : DbContext
    {
        public GetAnswerModel()
            : base("name=GetAnswerContext")
        {
        }

        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<DoctorateDegree> DoctorateDegree { get; set; }
        public virtual DbSet<FileType> FileType { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<QuestionAddition> QuestionAddition { get; set; }
        public virtual DbSet<QuestionAttachmentFile> QuestionAttachmentFile { get; set; }
        public virtual DbSet<RefreshTokens> RefreshTokens { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserInterestTag> UserInterestTag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);
        }
    }
}
