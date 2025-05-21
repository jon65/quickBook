using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quickBook.Infra.Models
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public Guid ServiceId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        [Required]
        [EnumDataType(typeof(BookingStatus))]
        public BookingStatus Status { get; set; } = BookingStatus.Pending;

        // Navigation properties (optional)
        public Customer Customer { get; set; }
        public Service Service { get; set; }
    }

    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Completed
    }
}
