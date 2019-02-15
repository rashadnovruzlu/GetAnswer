namespace GetAnswer.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QuestionAddition")]
    public partial class QuestionAddition : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }

        public bool AnswerSendEmail { get; set; }

        public bool AnswerSendPhone { get; set; }
    }
}
