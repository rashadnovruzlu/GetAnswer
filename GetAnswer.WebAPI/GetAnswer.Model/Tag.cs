namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [Column("Tag")]
        [Required]
        [StringLength(50)]
        public string Tag1 { get; set; }

        public int Count { get; set; }
    }
}
