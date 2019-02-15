namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tag")]
    public partial class Tag : Entity<int>
    {
        public int CategoryId { get; set; }

        [Column("Tag")]
        [Required]
        [StringLength(50)]
        public string Tag1 { get; set; }

        public int Count { get; set; }
    }
}
