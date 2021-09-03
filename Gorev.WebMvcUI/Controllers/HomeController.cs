using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Gorev.DAL;
using Gorev.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gorev.WebMvcUI.Models;

namespace Gorev.WebMvcUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GorevlerContext _db;

        public HomeController(ILogger<HomeController> logger, GorevlerContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gorevler()
        {
            return View(_db.Gorevlers.AsEnumerable());
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
