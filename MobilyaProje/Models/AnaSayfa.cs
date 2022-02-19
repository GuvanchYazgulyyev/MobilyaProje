using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MobilyaProje.Models
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string Banner { get; set; }
        public string Banner1 { get; set; }
        public string Banner2 { get; set; }
        public string SloganKucuk { get; set; }
        public string SloganKucuk1 { get; set; }
        public string SloganKucuk2 { get; set; }
        public string SloganBuyuk { get; set; }
        public string SloganBuyuk1 { get; set; }
        public string SloganBuyuk2 { get; set; }
        public string NeYapiyoruzBaslik { get; set; }
        public string SurecimizBaslik { get; set; }
        public string YorumBalik { get; set; }
    }
}