namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QuestionAttachmentFile")]
    public partial class QuestionAttachmentFile : Entity<int>
    {
        public int QuestionId { get; set; }

        [Required]
        [StringLength(125)]
        public string FileName { get; set; }

        public int FileTypeId { get; set; }

        public bool Status { get; set; }
    }
}
