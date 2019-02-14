namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        [Required]
        [StringLength(250)]
        public string Tags { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public int? CorrectAnswerId { get; set; }

        public int ViewCount { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }
    }
}
