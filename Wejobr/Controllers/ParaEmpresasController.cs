using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Wejobr.Controllers
{
    public class ParaEmpresasController : Controller
    {
      
        private readonly ILogger<ParaEmpresasController> _logger;

        public ParaEmpresasController(ILogger<ParaEmpresasController> logger)
        {
            _logger = logger;
        }

        public IActionResult ParaEmpresas()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}

