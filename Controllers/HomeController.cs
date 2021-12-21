using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoNovaViagens.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNovaViagens.Controllers
{
    public class HomeController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }



        public IActionResult destinos()
        {
            return View();
        }

        public IActionResult promocoes()
        {
            return View();
        }

        public IActionResult contato()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }









        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
