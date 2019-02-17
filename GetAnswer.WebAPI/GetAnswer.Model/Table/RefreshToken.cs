namespace GetAnswer.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class RefreshToken : Entity<string>
    {
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientId { get; set; }

        public DateTime IssuedUtc { get; set; }

        public DateTime ExpiresUtc { get; set; }

        [Required]
        public string ProtectedTicket { get; set; }
    }
}
