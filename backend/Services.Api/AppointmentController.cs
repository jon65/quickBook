using Microsoft.AspNetCore.Mvc;
using quickBook.ApiController;

namespace quickBook.ApiController;

public class AppointmentsController : BaseApiController
{
    private readonly BookAppointmentUseCase _useCase;

    public AppointmentsController(BookAppointmentUseCase useCase)
    {
        _useCase = useCase;
    }

    [HttpPost]
    public async Task<IActionResult> BookAppointment([FromBody] BookAppointmentDto dto)
    {
        var id = await _useCase.ExecuteAsync(dto);
        return Ok(new { AppointmentId = id });
    }
}
