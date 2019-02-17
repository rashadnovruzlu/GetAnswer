namespace GetAnswer.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class VW_ALL_QUESTION : BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Body { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime CreatedDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ViewCount { get; set; }

        public int? AnswerCount { get; set; }

        public int? Votes { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(256)]
        public string UserName { get; set; }

        public string UserImage { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string Category { get; set; }

        public int? CorrectAnswerId { get; set; }

        public string Tags { get; set; }
    }
}
