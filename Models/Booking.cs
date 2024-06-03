using System;
using System.ComponentModel.DataAnnotations;

namespace Type_D.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ServiceName { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        public int UserId { get; set; }
        public UserProfile User { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Status { get; set; }
    }
}
