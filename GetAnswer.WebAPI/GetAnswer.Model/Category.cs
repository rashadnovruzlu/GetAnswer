namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int Id { get; set; }

        [Column("Category")]
        [Required]
        [StringLength(100)]
        public string Category1 { get; set; }

        public bool Status { get; set; }
    }
}
