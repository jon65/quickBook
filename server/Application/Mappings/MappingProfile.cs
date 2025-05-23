// File: Application/Mappings/MappingProfile.cs
using AutoMapper;
using quickBook.Application.DTO;
using quickBook.Infra.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Booking, BookingDto>();
        CreateMap<BookingDto, Booking>();
        CreateMap<CreateBookingDto, Booking>();
        // Add more mappings as needed
    }
}
