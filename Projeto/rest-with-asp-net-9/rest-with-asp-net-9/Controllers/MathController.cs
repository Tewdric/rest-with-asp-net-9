using Microsoft.AspNetCore.Mvc;
using rest_with_asp_net_9.Service;

namespace rest_with_asp_net_9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly MathService _mathService;
        public MathController(MathService calcService)
        {
            _mathService = calcService;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSoma(string firstNumber, string secondNumber)
        {
            try
            {
                var res = _mathService.Sum(firstNumber, secondNumber);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSub(string firstNumber, string secondNumber)
        {
            try
            {
                var res = _mathService.Subtration(firstNumber, secondNumber);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult GetMult(string firstNumber, string secondNumber)
        {
            try
            {
                var res = _mathService.Multiplication(firstNumber, secondNumber);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult GetDiv(string firstNumber, string secondNumber)
        {
            try
            {
                var res = _mathService.Division(firstNumber, secondNumber);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("med/{firstNumber}/{secondNumber}")]
        public IActionResult GetMed(string firstNumber, string secondNumber)
        {

            try
            {
                var res = _mathService.Mean(firstNumber, secondNumber);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("raiz/{firstNumber}")]
        public IActionResult GetRaiz(string firstNumber)
        {
            try
            {
                var res = _mathService.SquareRoot(firstNumber);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
