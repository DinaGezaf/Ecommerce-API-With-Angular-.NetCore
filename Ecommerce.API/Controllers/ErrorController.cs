using Ecommerce.API.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("errors/{code}")]
    [ApiController]
    public class ErrorController : BaseAPIController
    {
        [HttpGet("ErrorHandle")]
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
