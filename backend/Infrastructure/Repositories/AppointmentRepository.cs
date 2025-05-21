using Microsoft.EntityFrameworkCore;
using quickBook.Domain.Entities;
using quickBook.Domain.Enums;
using quickBook.Infra.Data.Context;

namespace quickBook.Infra.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly ApplicationDbContext _context;

    public AppointmentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Appointment?> GetByIdAsync(Guid id)
    {
        return await _context.Appointments
            .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<List<Appointment>> GetAvailableAppointmentsAsync()
    {
        return await _context.Appointments
            .Where(a => a.Status == AppointmentStatus.Pending) // or however you define availability
            .ToListAsync();
    }

    public async Task AddAsync(Appointment appointment)
    {
        await _context.Appointments.AddAsync(appointment);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
