namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInterestTag")]
    public partial class UserInterestTag
    {
        public int Id { get; set; }

        public int TagId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }
    }
}
