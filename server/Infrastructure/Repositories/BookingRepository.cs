using quickBook.Domain.Interfaces;
using quickBook.Infra.Models;
using server.Data;

public class BookingRepository : IBookingRepository
{
    private readonly ApplicationDbContext _context;

    public BookingRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task AddAsync(Booking booking)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Booking booking)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Booking>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Booking> GetByIdAsync(Guid id) => 
        await _context.Bookings.FindAsync(id);

    public Task UpdateAsync(Booking booking)
    {
        throw new NotImplementedException();
    }

    Task<Booking> IBookingRepository.GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    // Other methods ...
}
