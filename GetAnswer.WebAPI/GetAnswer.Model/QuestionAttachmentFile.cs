namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionAttachmentFile")]
    public partial class QuestionAttachmentFile
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        [Required]
        [StringLength(125)]
        public string FileName { get; set; }

        public int FileTypeId { get; set; }

        public bool Status { get; set; }
    }
}
