using Microsoft.AspNetCore.Mvc;
using InjectWebApi.Interfaces;

namespace InjectWebApi.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class CalculatorController: ControllerBase{
         private readonly ICalculator _calculatorService;

        // Constructor injection of ICalculatorService
        public CalculatorController(ICalculator calculatorService)
        {
            _calculatorService = calculatorService;
        }

        // Endpoint for adding two numbers
        [HttpGet("add")]
        public IActionResult Add(decimal left, decimal right)
        {
            var result = _calculatorService.Add(left, right);
            return Ok(result);
        }

        // Endpoint for subtracting two numbers
        [HttpGet("subtract")]
        public IActionResult Subtract(decimal left, decimal right)
        {
            var result = _calculatorService.Subtract(left, right);
            return Ok(result);
        }

         // Endpoint for multiplying two numbers
        [HttpGet("multiply")]
        public IActionResult Multiply(decimal left, decimal right)
        {
            var result = _calculatorService.Multiply(left, right);
            return Ok(result);
        }

        // Endpoint for dividing two numbers
        [HttpGet("divide")]
        public IActionResult Divide(decimal left, decimal right)
        {
            try
            {
                var result = _calculatorService.Divide(left, right);
                return Ok(result);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}