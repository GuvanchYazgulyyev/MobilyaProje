using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class Galeriicerik
    {
        [Key]
        public int id { get; set; }
        public string Baslik { get; set; }
        public string Resim { get; set; }
        public string Tarih { get; set; }
        public string Konum { get; set; }
        public string Deger { get; set; }
        public string Musteri { get; set; }
        public string Kategori { get; set; }
        public string icerik { get; set; }
        public string AltBaslik { get; set; }
        public string icerik1 { get; set; }

        public virtual List<Galeri> GetGaleris { get; set; }
    }
}