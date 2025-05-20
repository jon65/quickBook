using Microsoft.AspNetCore.Mvc;

namespace quickBook.ApiController
{
    public class BookingController : BaseApiController
    {
        // GET: api/test/ping
        [HttpGet("/")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}



//This will respond to GET /api/test/ping with "pong".

