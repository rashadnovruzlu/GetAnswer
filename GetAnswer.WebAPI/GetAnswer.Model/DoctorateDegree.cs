namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DoctorateDegree")]
    public partial class DoctorateDegree : Entity<byte>
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool Status { get; set; }
    }
}
