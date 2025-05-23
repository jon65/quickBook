using quickBook.Application.DTO;

namespace quickBook.Application.Services;

public interface IBookingService
    {
        Task<IEnumerable<BookingDto>> GetAllBookingsAsync();
        Task<BookingDto> GetBookingByIdAsync(Guid id);
        Task<BookingDto> CreateBookingAsync(CreateBookingDto input);
        Task<bool> UpdateBookingAsync(Guid id, UpdateBookingDto input);
        Task<bool> DeleteBookingAsync(Guid id);
    }
