using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using quickBook.Domain.Interfaces;
using quickBook.Infra.Models;

namespace quickBook.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;

        public BookingService(IBookingRepository bookingRepository, IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookingDto>> GetAllBookingsAsync()
        {
            var bookings = await _bookingRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BookingDto>>(bookings);
        }

        public async Task<BookingDto> GetBookingByIdAsync(Guid id)
        {
            var booking = await _bookingRepository.GetByIdAsync(id);
            return _mapper.Map<BookingDto>(booking);
        }

        public async Task<BookingDto> CreateBookingAsync(CreateBookingDto input)
        {
            var booking = _mapper.Map<Booking>(input);

            // Optional: Calculate EndTime based on Service Duration
            // You could get the service duration from another repository here

            await _bookingRepository.AddAsync(booking);
            return _mapper.Map<BookingDto>(booking);
        }

        public async Task<bool> UpdateBookingAsync(Guid id, UpdateBookingDto input)
        {
            var booking = await _bookingRepository.GetByIdAsync(id);
            if (booking == null) return false;

            _mapper.Map(input, booking);
            await _bookingRepository.UpdateAsync(booking);
            return true;
        }

        public async Task<bool> DeleteBookingAsync(Guid id)
        {
            var booking = await _bookingRepository.GetByIdAsync(id);
            if (booking == null) return false;

            await _bookingRepository.DeleteAsync(booking);
            return true;
        }
    }
}
