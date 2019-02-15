namespace GetAnswer.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Comment")]
    public partial class Comment : Entity<int>
    {
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
