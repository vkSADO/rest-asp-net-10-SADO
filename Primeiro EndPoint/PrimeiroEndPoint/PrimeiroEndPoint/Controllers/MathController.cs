using Microsoft.AspNetCore.Mvc;

namespace PrimeiroEndPoint.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class MathController : ControllerBase
    {
        [HttpGet("sum/{var1}/{var2}")]
        public IActionResult Get(string var1, string var2)
        {
            if(var1 == "1" && var2 == "1")
            {
                return Ok("1");
            }
           
            return BadRequest("Deu erro!"); 
        }
    }
}
