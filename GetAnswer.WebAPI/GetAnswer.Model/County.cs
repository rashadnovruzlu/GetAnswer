namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("County")]
    public partial class County
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string CountryName { get; set; }

        public bool Status { get; set; }
    }
}
