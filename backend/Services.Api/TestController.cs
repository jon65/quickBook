using Microsoft.AspNetCore.Mvc;

namespace quickBook.ApiController
{
    public class TestController : BaseApiController
    {
        // GET: api/test/ping
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}
//This will respond to GET /api/test/ping with "pong".

