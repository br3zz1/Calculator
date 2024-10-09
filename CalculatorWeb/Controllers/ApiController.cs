using CalculatorWeb.Models.Api;
using CalculatorWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWeb.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ICalculationService _calculationService;

        public ApiController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpGet("evaluate")]
        public IActionResult Evaluate(string expression)
        {
            var result = _calculationService.Evaluate(expression);
            
            var response = new EvaluateResponse() { Result = result };

            return Ok(response);
        }
    }
}
