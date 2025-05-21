using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace quickBook.Infra.Models
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal Price { get; set; }

        // Navigation property
        public ICollection<Booking> Bookings { get; set; }
    }
}
