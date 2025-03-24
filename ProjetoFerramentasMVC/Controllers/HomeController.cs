using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoFerramentasMVC.Models;

namespace ProjetoFerramentasMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Redireciona para a página de login
        public IActionResult Index()
        {
            return RedirectToAction("Login", "Account"); // Redireciona para a Action Login do AccountController
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
