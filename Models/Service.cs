using System.ComponentModel.DataAnnotations;

namespace Type_D.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
