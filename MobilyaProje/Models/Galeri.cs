using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class Galeri
    {
        [Key]
        public int id { get; set; }
        public string Resim { get; set; }

        public int Galeriid { get; set; }
        public virtual Galeriicerik GetGaleriicerik { get; set; }
    }
}