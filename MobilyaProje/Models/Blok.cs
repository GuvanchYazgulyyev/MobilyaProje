using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class Blok
    {
        [Key]
        public int id { get; set; } 
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public string icerik1 { get; set; }
        public string icerik2 { get; set; }
        public string Resim { get; set; }
        public string Gun { get; set; }
        public string Ay { get; set; }
    }
}