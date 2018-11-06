using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supremo.Models;

namespace Supremo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _repository;
        public HomeController(IProdutoRepository repository)
        {
            _repository = repository;        
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}