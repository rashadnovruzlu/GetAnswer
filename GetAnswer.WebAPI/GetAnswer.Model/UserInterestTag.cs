namespace GetAnswer.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserInterestTag")]
    public partial class UserInterestTag : Entity<int>
    {
        public int TagId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }
    }
}
