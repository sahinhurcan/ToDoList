using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoTest.Models;

namespace ToDoTest.Controllers
{
    public class FirmaController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult FirmaEkle(string firma)
        {
            Firmalar f = new Firmalar();
            f.FirmaAdi = firma;
            c.Firmalars.Add(f);
            c.SaveChanges();

            return Json(new { success = true });

        }
    }
}
