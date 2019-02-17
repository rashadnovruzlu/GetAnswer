namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Answer")]
    public partial class Answer : Entity<int>
    {
        public Answer()
        {
            Comments = new HashSet<Comment>();
            Questions = new HashSet<Question>();
        }

        public int QuestionId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        [Required]
        public string Body { get; set; }

        public int UsefulCount { get; set; }

        public int NotUsefulCount { get; set; }

        public byte IsCorrectAnswer { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Status { get; set; }

        public virtual Question Question { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
        
        public virtual ICollection<Question> Questions { get; set; }
    }
}
