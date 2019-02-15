namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;

    public partial class AspNetUserClaims : Entity<int>
    {
        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public string ClaimType { get; set; }

        public string ClaimValue { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
