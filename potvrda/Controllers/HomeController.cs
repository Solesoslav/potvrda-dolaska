using Microsoft.AspNetCore.Mvc;
using potvrda.Models;
using System.Linq;


namespace potvrda.Controllers
{

    public class HomeController : Controller
    {
        private DataContext context;

        public HomeController(DataContext ctx) => context = ctx;

        public IActionResult Index() => View();

        public IActionResult Odgovor() => View();

        [HttpPost]
        public IActionResult Odgovor(OdgovoriRoditelja odgovor)
        {
            if (ModelState.IsValid)
            {
                context.Odgovori.Add(odgovor);
                context.SaveChanges();
                return RedirectToAction(nameof(VidimoSe),
                    new { ImeDeteta = odgovor.ImeDeteta, PotvrdaDolaska = odgovor.PotvrdaDolaska });
            }
            else return View(odgovor);
        }

        public IActionResult VidimoSe(OdgovoriRoditelja odgovor) => View(odgovor);

        public IActionResult ListaOdgovora() =>
            View(context.Odgovori.OrderByDescending(r => r.PotvrdaDolaska));
    }
}

