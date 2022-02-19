using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class Referans
    {
        [Key]
        public int id { get; set; }
        public string Resim { get; set; }
    }
}