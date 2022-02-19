using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class MusteriYorum
    {
        [Key]
        public int id { get; set; }
        public string Yorum { get; set; }
        public string AdSoyad { get; set; }
    }
}