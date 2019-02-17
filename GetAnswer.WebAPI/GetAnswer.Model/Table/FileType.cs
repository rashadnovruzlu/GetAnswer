namespace GetAnswer.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FileType")]
    public partial class FileType : Entity<int>
    {
        public FileType()
        {
            QuestionAttachmentFiles = new HashSet<QuestionAttachmentFile>();
        }

        [Required]
        [StringLength(10)]
        public string Extension { get; set; }

        [Required]
        [StringLength(200)]
        public string MIMEType { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<QuestionAttachmentFile> QuestionAttachmentFiles { get; set; }
    }
}
