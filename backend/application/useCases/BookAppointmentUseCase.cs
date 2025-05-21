using quickBook.Domain.Entities;
using quickBook.Domain.Enums;
using quickBook.Domain.ValueObjects;

public class BookAppointmentUseCase
{
    private readonly IAppointmentRepository _repository;

    public BookAppointmentUseCase(IAppointmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> ExecuteAsync(BookAppointmentDto dto)
    {
        var appointment = new Appointment(
            new Guid(),
            AppointmentStatus.Pending,
            new TimeSlot(dto.Start, dto.End),
            dto.Service
        );

        await _repository.AddAsync(appointment);
        await _repository.SaveChangesAsync();

        return appointment.Id;
    }
}
