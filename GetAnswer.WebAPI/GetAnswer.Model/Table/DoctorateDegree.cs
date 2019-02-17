namespace GetAnswer.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DoctorateDegree")]
    public partial class DoctorateDegree : Entity<byte>
    {
        public DoctorateDegree()
        {
            UserInfoes = new HashSet<UserInfo>();
        }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<UserInfo> UserInfoes { get; set; }
    }
}
