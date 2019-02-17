namespace GetAnswer.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("City")]
    public partial class City : Entity<int>
    {
        public City()
        {
            UserInfoes = new HashSet<UserInfo>();
        }

        public int CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CityName { get; set; }

        public bool Status { get; set; }

        public virtual County County { get; set; }

        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}
