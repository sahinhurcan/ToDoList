using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTest.Models
{
    public class kullanicilar
    {
        [Key]
        public int ID { get; set; }
        public string PersonelAd { get; set; }
        public int  YetkiID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
