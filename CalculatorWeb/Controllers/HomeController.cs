using CalculatorWeb.Models.Home;
using CalculatorWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculationService _calculationService;

        public HomeController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public IActionResult Index()
        {
            var model = new IndexModel() { MainInputText = "" };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(IndexModel model)
        {
            var result = _calculationService.Evaluate(model.MainInputText);

            var newModel = new IndexModel() { MainInputText = result };
            
            ModelState.Clear();

            return View(newModel);
        }
    }
}
