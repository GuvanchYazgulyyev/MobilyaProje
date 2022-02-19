using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class BlokSayfa
    {
        [Key]
        public int id { get; set; }
        public string Slogan { get; set; }
        public string Banner { get; set; }

    }
}