using System;
using System.ComponentModel.DataAnnotations;

namespace Type_D.Models
{
    public class Booking
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
    }
}
