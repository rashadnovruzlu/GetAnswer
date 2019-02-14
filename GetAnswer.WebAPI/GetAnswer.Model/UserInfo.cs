namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInfo")]
    public partial class UserInfo
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
