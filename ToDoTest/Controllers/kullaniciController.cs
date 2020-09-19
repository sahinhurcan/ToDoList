using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ToDoTest.Models;
namespace ToDoTest.Controllers
{
    [Authorize]
    public class kullaniciController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var kullanicilar = c.kullanicilars.ToList();
            return View(kullanicilar);
        }
        [HttpGet]
        public IActionResult KullaniciEkle()
        {
            return View();
        }
        Context x = new Context();


        [HttpPost]
        public IActionResult KullaniciEkle(kullanicilar k)
        {
            x.kullanicilars.Add(k);
            x.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult KullaniciSil(int id)
        {
            var kullanici = c.kullanicilars.Find(id);
            c.kullanicilars.Remove(kullanici);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult KullaniciGetir(int id)
        {
            var kullanici = c.kullanicilars.Find(id);
            return View("KullaniciGetir", kullanici);

        }
        public IActionResult KullaniciGuncelle(kullanicilar k)
        {
            var user = c.kullanicilars.Find(k.ID);
            user.PersonelAd = k.PersonelAd;
            user.KullaniciAdi = k.KullaniciAdi;
            user.Sifre = k.Sifre;
            user.YetkiID = k.YetkiID;


            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
