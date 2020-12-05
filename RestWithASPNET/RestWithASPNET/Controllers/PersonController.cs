using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            double firstNumberCast;
            double secondNumberCast;
            if (double.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out firstNumberCast) && double.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out secondNumberCast))
            {
                double result = firstNumberCast + secondNumberCast;
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtract/{firstNumber}/{secondNumber}")]
        public IActionResult Subtract(string firstNumber, string secondNumber)
        {
            double firstNumberCast;
            double secondNumberCast;
            if (double.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out firstNumberCast) && double.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out secondNumberCast))
            {
                double result = firstNumberCast - secondNumberCast;
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiply/{firstNumber}/{secondNumber}")]
        public IActionResult Multiply(string firstNumber, string secondNumber)
        {
            double firstNumberCast;
            double secondNumberCast;
            if (double.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out firstNumberCast) && double.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out secondNumberCast))
            {
                double result = firstNumberCast * secondNumberCast;
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("divide/{firstNumber}/{secondNumber}")]
        public IActionResult Divide(string firstNumber, string secondNumber)
        {
            double firstNumberCast;
            double secondNumberCast;
            if (double.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out firstNumberCast) && double.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out secondNumberCast))
            {
                double result = firstNumberCast / secondNumberCast;
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("Square/{firstNumber}")]
        public IActionResult Square(string firstNumber)
        {
            double firstNumberCast;            
            if (double.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out firstNumberCast))
            {
                double result = Math.Sqrt(firstNumberCast);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber)
        {
            double firstNumberCast;
            double secondNumberCast;
            if (double.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out firstNumberCast) && double.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out secondNumberCast))
            {
                double result = (firstNumberCast + secondNumberCast)/2;
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }
    }
}
