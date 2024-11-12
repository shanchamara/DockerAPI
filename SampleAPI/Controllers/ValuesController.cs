using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet("test-one")]
        public IActionResult TestOne()
        {
            return Ok("TestOne response ok ");
        }
    }

}
