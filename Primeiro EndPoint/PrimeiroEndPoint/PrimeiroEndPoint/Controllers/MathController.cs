using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace PrimeiroEndPoint.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class MathController : ControllerBase
    {
        [HttpGet("sum/{var1}/{var2}")]
        public IActionResult Sum(string var1, string var2)
        {
           if(!TryConvertToDecimal(var1,out var n1) || !TryConvertToDecimal(var2, out var n2))
           {
                return BadRequest(); 
           }
            return Ok(n1 + n2);
        }

        [HttpGet("sub/{var1}/{var2}")]
        public IActionResult Sub(string var1, string var2)
        {
            if (!TryConvertToDecimal(var1, out var n1) || !TryConvertToDecimal(var2, out var n2))
            {
                return BadRequest();
            }
            return Ok(n1 - n2);
        }

        [HttpGet("mult/{var1}/{var2}")]
        public IActionResult Mult(string var1, string var2)
        {
            if(!TryConvertToDecimal(var1, out var n1) || !TryConvertToDecimal(var2, out var n2))
            {
                return BadRequest();
            }
            return Ok(n1 * n2);
        }

        [HttpGet("div/{var1}/{var2}")]
        public IActionResult Div(string var1, string var2)
        {
            if (!TryConvertToDecimal(var1, out var n1) || !TryConvertToDecimal(var2, out var n2))
            {
                return BadRequest();
            }
            return Ok(n1 / n2);
        }

        [HttpGet("mid/{var1}/{var2}")]
        public IActionResult Mid(string var1, string var2)
        {
            if (!TryConvertToDecimal(var1, out var n1) || !TryConvertToDecimal(var2, out var n2))
            {
                return BadRequest();
            }
            return Ok((n1 + n2)/2);
        }

        [HttpGet("sqrt/{var1}")]
        public IActionResult Sqrt(string var1)
        {
            if (!TryConvertToDecimal(var1, out var n1))
            {
                return BadRequest();
            }
            var result = (Math.Sqrt((double)n1));
            return Ok(Math.Round(result,2));
        }



        // Metodo que converte string para um valor decimal
        private bool TryConvertToDecimal(string input, out decimal value)
        {

            return decimal.TryParse(input, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out value);
          
        }

        
    }
}
