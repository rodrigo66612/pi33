using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pi3.Models;

namespace pi3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult faleConosco()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
          [HttpPost]
        public IActionResult Contato(formaContato formaContato)
        {
            if (ModelState.IsValid)
            {
                // Processar o envio do comentario

                return RedirectToAction("obrigado");
            }
            return View(formaContato);
        }


        public IActionResult obrigado()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

         public IActionResult serviço()
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
