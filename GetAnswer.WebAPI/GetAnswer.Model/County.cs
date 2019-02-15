namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("County")]
    public partial class County : Entity<int>
    {
        [Required]
        [StringLength(200)]
        public string CountryName { get; set; }

        public bool Status { get; set; }
    }
}
