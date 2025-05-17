using Booking.Grpc;
using Grpc.Core;
using System.Threading.Tasks;
using System;

public class AppointmentService : Booking.Grpc.AppointmentService.AppointmentServiceBase
{
    // You can inject a DB service or repository here
    public override Task<AppointmentResponse> CreateAppointment(CreateAppointmentRequest request, ServerCallContext context)
    {
        // Simulate appointment creation logic
        var appointmentId = Guid.NewGuid().ToString();

        return Task.FromResult(new AppointmentResponse
        {
            AppointmentId = appointmentId,
            Status = "CREATED",
            Message = "Appointment successfully created"
        });
    }

    public override Task<AppointmentResponse> GetAppointment(GetAppointmentRequest request, ServerCallContext context)
    {
        // Simulate fetching an appointment (you’d normally query a database)
        return Task.FromResult(new AppointmentResponse
        {
            AppointmentId = request.AppointmentId,
            Status = "CONFIRMED",
            Message = "Appointment fetched"
        });
    }
}
