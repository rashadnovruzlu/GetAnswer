namespace GetAnswer.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tag")]
    public partial class Tag : Entity<int>
    {
        public Tag()
        {
            UserInterestTags = new HashSet<UserInterestTag>();
            Questions = new HashSet<Question>();

        }

        public int CategoryId { get; set; }

        [Column("Tag")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Count { get; set; }

        public virtual ICollection<UserInterestTag> UserInterestTags { get; set; }

        public virtual ICollection<Question> Questions { get; set; }


    }
}
