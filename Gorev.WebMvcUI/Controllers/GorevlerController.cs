using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gorev.DAL;
using Gorev.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gorev.WebMvcUI.Controllers
{
    public class GorevlerController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GorevlerContext _db;

        public GorevlerController(ILogger<HomeController> logger, GorevlerContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Gorevlers.AsEnumerable());
        }

        [HttpGet]
        public IActionResult YeniGorev()
        {
            return View(new Gorevler());
        }

        [HttpPost]
        public IActionResult YeniGorev(Gorevler gorev)
        {
            if (ModelState.IsValid)
            {
                _db.Add(gorev);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gorev);
        }

        public IActionResult Duzenle(int Id)
        {
            var bul = _db.Gorevlers.FirstOrDefault(i => i.Id == Id);
            return View(bul);
        }

        [HttpPost]
        public IActionResult Duzenle(Gorevler gorevler)
        {
            if (ModelState.IsValid)
            {
                var degistir = _db.Gorevlers.Find(gorevler.Id);
                degistir.GorevAdi = gorevler.GorevAdi;
                degistir.IsCompleted = gorevler.IsCompleted;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gorevler);
        }

        [HttpGet]
        public IActionResult Sil(int Id)
        {
            var bul = _db.Gorevlers.FirstOrDefault(i => i.Id == Id);
            return View(bul);
        }

        [HttpPost]
        public IActionResult Sil(Gorevler gorevler)
        {

            var sil = _db.Gorevlers.Find(gorevler.Id);
            _db.Remove(sil);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}