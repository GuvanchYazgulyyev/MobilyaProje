using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class Hakkimizda
    {
        [Key]
        public int id { get; set; }
        public string Slogan { get; set; }
        public string Banner { get; set; }
        public string Baslik { get; set; }
        public string Resim { get; set; }
        public string icerik { get; set; }
    }
}