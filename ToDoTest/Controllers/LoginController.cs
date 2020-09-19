using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ToDoTest.Models;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace ToDoTest.Controllers
{
    public class LoginController : Controller
    {
       
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
        Context c = new Context();


        public async  Task<IActionResult> GirisYap(kullanicilar k)
        {
            var giris = c.kullanicilars.FirstOrDefault(x => x.KullaniciAdi == k.KullaniciAdi && x.Sifre == k.Sifre);
            if (giris != null)
            {
                HttpContext.Session.SetString("UserID", giris.ID.ToString());
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,k.KullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        public async Task<IActionResult> CikisYap()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
