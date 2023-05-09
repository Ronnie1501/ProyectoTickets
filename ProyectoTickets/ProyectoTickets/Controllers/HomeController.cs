using Microsoft.AspNetCore.Mvc;
using ProyectoTickets.Models;
using System.Diagnostics;

namespace ProyectoTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Compras()  
        {
            SuperTicketContext _context = new SuperTicketContext();
            var ListarUsuarios = _context.Usuarios.ToList();
            return View(ListarUsuarios);
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