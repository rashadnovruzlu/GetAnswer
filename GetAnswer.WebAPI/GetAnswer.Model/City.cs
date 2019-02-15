namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City : Entity<int>
    {
        public int CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CityName { get; set; }

        public bool Status { get; set; }
    }
}
