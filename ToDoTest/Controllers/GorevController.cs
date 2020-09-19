using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Todoist.Net;
using Todoist.Net.Models;
using ToDoTest.Models;

namespace ToDoTest.Controllers
{
    [Authorize]
    public class GorevController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var gorevler = c.gorevlers.ToList();

            return View(gorevler);
        }
        public IActionResult FirmaGorevleri(int frm)
        {
            var firmagorev = c.gorevlers.Where(x => x.Firma == frm).ToList<gorevler>();
            return View(firmagorev);
        }
        public IActionResult YapildiIsaretle(int id)
        {
            var gorev = c.gorevlers.Find(id);

            gorev.Durumu = "Yapıldı";
            c.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult GorevGetir(int id)
        {
            var gorev = c.gorevlers.Find(id);
            return View("GorevGetir", gorev);

        }
        public IActionResult GorevGuncelle(gorevler g)
        {
            var gorev = c.gorevlers.Find(g.id);
            gorev.GorevDetay = g.GorevDetay;
            gorev.Firma = g.Firma;
            gorev.Durumu = g.Durumu;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult GorevSil(int id)
        {
            var gorev = c.gorevlers.Find(id);
            c.gorevlers.Remove(gorev);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        //
        [HttpGet]
        public IActionResult GorevEkle()
        {
            List<SelectListItem> kullanicilar = (from x in Ayarlar.Firmalar()
            select new SelectListItem {

                Text=x.FirmaAdi.ToString(),
                Value=x.ID.ToString()
            
            }).ToList();
            ViewBag.usr = kullanicilar;
            

            return View();
        }
        ITodoistClient client = new TodoistClient("01ba52a56cec860c1ec49af5b667bbbac5ff3b1d");
       
        [HttpPost]
        public async Task<IActionResult> GorevEkleAsync(gorevler g)
        {
           
            c.gorevlers.Add(g);
            c.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}
