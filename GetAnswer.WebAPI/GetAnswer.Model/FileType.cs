namespace GetAnswer.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileType")]
    public partial class FileType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Extension { get; set; }

        [Required]
        [StringLength(200)]
        public string MIMEType { get; set; }

        public bool Status { get; set; }
    }
}
