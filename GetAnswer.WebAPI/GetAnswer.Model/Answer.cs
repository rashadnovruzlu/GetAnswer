namespace GetAnswer.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Answer")]
    public partial class Answer
    {
        public int Id { get; set; }

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
    }
}
