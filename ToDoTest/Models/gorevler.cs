using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTest.Models
{
    public class gorevler
    {

        [Key]
        public int id { get; set; }
        public string GorevDetay { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public string Durumu { get; set; }
        public int Firma{ get; set; }
        public string KullaniciID { get; set; }

    }
   
}
