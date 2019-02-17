namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Question")]
    public partial class Question : Entity<int>
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            QuestionAttachmentFiles = new HashSet<QuestionAttachmentFile>();
            TagList = new HashSet<Tag>();

        }

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

        public int UsefulCount { get; set; }

        public int NotUsefulCount { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        public virtual Answer Answer { get; set; }

        public virtual Category Category { get; set; }

        public virtual QuestionAddition QuestionAddition { get; set; }

        public virtual ICollection<QuestionAttachmentFile> QuestionAttachmentFiles { get; set; }

        public virtual ICollection<Tag> TagList { get; set; }
    }
}
