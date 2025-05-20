using Microsoft.AspNetCore.Mvc;

namespace quickBook.ApiController
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller { }
}