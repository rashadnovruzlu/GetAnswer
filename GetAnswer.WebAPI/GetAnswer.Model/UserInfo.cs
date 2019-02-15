namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserInfo")]
    public partial class UserInfo : BaseEntity
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        public byte? DoctorateDegreeId { get; set; }

        public int? CityId { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        public string Base64Image { get; set; }

        public string About { get; set; }
    }
}
