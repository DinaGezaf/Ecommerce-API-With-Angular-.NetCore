using Ecommerce.API.Errors;
using Ecommerce.DAL.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuggyController : BaseAPIController
    {
        private readonly StoreContext _storeContext;
        public BuggyController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        [HttpGet("Not Found")]
        public IActionResult GetNotFoundRequest()
        {
            var thing = _storeContext.Products.Find(45);
            if (thing == null) return NotFound(new ApiResponse(404));
            return Ok();
        }
        [HttpGet("Server Error")]
        public IActionResult GetServerError()
        {
            var thing = _storeContext.Products.Find(45);
            var ThingToReturn = thing.ToString();
            return Ok();
        }

        [HttpGet("Bad Request")]
        public IActionResult GetBadRerquest()
        {
            return BadRequest(new ApiResponse(400));
        }
        [HttpGet("Not Found Request/{id}")]
        public IActionResult GetNotFoundRequest(int id)
        {
            return Ok();
        }

    }
}
