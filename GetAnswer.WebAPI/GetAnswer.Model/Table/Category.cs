namespace GetAnswer.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Category")]
    public partial class Category : Entity<int>
    {
        public Category()
        {
            Questions = new HashSet<Question>();
        }


        [Column("Category")]
        [Required]
        [StringLength(100)]
        public string Category1 { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
