namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionAddition")]
    public partial class QuestionAddition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }

        public bool AnswerSendEmail { get; set; }

        public bool AnswerSendPhone { get; set; }
    }
}
