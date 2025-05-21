
public class CreateBookingDto
{
    public Guid CustomerId { get; set; }
    public Guid ServiceId { get; set; }
    public DateTime StartTime { get; set; }
    public required string Notes { get; set; }
}
