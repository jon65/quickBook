using quickBook.Infra.Models;

namespace quickBook.Domain.Interfaces;

public interface IBookingRepository
{
    Task<IEnumerable<Booking>> GetAllAsync();
    Task AddAsync(Booking booking);
    Task UpdateAsync(Booking booking);
    Task DeleteAsync(Booking booking);
    Task<Booking> GetByIdAsync(Guid id);

}
