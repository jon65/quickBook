// Models/Appointment.cs
public class Appointment
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public string Status { get; set; }
}

// Models/AppointmentRequest.cs
public class AppointmentRequest
{
    public string UserId { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
}


