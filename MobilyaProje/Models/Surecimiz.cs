using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class Surecimiz
    {
        [Key]
        public int id { get; set; }
        public string Surec { get; set; }
        public string icerik { get; set; }
        public string Surec1 { get; set; }
        public string icerik1 { get; set; }
        public string Surec2 { get; set; }
        public string iceri2 { get; set; }
        public string Surec3 { get; set; }
        public string icerik3 { get; set; }
    }
}