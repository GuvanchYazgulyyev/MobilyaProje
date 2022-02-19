using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class NeYapiyoruz
    {
        [Key]
        public int id { get; set; }
        public string Slogan { get; set; }
        public string Baslik { get; set; }
        public string Baslik1 { get; set; }
        public string icerik { get; set; }
        public string Resim { get; set; }
        public string Resim1 { get; set; }
        public bool Durum { get; set; }
        public virtual ICollection<FormGonder> FormGonders { get; set; }


    }
}