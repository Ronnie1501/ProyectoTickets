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

        
        public IActionResult Privacy()
        {
            SuperTicketContext context = new SuperTicketContext();
            var ListarUsuarios = context.Usuarios.ToList();
            return View(ListarUsuarios);
        }
        [HttpGet]



        [HttpGet]
        public IActionResult Index()
        {
            SuperTicketContext context = new SuperTicketContext();
            var LisTicket = context.Tickets.ToList();
            return View(LisTicket);
        }


        [HttpGet]
        public IActionResult Compras()
        {
            SuperTicketContext context = new SuperTicketContext();
            var Liscompra = context.Compras.ToList();
            return View(Liscompra);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}