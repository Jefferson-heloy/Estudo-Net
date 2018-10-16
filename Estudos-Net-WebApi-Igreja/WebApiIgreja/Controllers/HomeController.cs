using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiIgreja.AcessoDados;
using WebApiIgreja.Models;

namespace WebApiIgreja.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFilmeRepository _repository;
        public HomeController(IFilmeRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.ListarFilmes());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
