using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace PrimeiroEndPoint.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class MathController : ControllerBase
    {
        [HttpGet("sum/{var1}/{var2}")]
        public IActionResult Get(string var1, string var2)
        {
            if(IsNumeric(var1) && IsNumeric(var2))
            {
                var sum = ConvertToDecimal(var1) + ConvertToDecimal(var2);
                return Ok(sum);
            }
           
            return BadRequest("Deu erro!"); 
        }

        private decimal ConvertToDecimal(string var)
        {
            decimal value;
           if(decimal.TryParse(var, NumberStyles.Any,NumberFormatInfo.InvariantInfo,out value))
           {
                return value;

           }
            return 0;
        }

        private bool IsNumeric(string var)
        {
            decimal result;
            bool isNumeric = decimal.TryParse(var, NumberStyles.Any,NumberFormatInfo.InvariantInfo,out  result);
            return isNumeric;
        }
    }
}
