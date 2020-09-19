using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoTest.Migrations;
using ToDoTest.Models;

namespace ToDoTest
{
    public class Ayarlar
    {
        public static Context c = new Context();

        public static List<Firmalar> Firmalar()
        {

            List<Firmalar> fr= c.Firmalars.ToList();
          
           
            return fr;
        }
        public static List<kullanicilar> Kullanicilar()
        {

            List<kullanicilar> kl = c.kullanicilars.ToList();


            return kl;
        }


        public static string FirmaGetir(int frm) { 
          
            
            string firmaad = "";

            Firmalar fr = c.Firmalars.Where(x => x.ID == frm).FirstOrDefault<Firmalar>();

            return fr.FirmaAdi;
        }


    }
}
