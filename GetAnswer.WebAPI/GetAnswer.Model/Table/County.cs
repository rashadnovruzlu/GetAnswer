namespace GetAnswer.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("County")]
    public partial class County : Entity<int>
    {
        public County()
        {
            Cities = new HashSet<City>();
        }

        [Required]
        [StringLength(200)]
        public string CountryName { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
