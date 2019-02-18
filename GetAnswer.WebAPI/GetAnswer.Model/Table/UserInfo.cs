namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserInfo")]
    public partial class UserInfo : BaseEntity
    {
        [Key]
        public string UserId { get; set; }

        public byte? DoctorateDegreeId { get; set; }

        public int? CityId { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        public string Base64Image { get; set; }

        public string About { get; set; }

        public int Point { get; set; }

        public int QuestionCount { get; set; }

        public int AnswerCount { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual City City { get; set; }

        public virtual DoctorateDegree DoctorateDegree { get; set; }
    }
}
