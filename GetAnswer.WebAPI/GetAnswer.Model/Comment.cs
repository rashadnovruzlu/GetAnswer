namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int Id { get; set; }

        public int AnsweId { get; set; }

        [Column("Comment")]
        [Required]
        public string Comment1 { get; set; }

        public DateTime? ReadDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }
    }
}
