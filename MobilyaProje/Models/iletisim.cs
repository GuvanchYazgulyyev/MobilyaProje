using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class iletisim
    {
        [Key]
        public int id { get; set; }
        public string Slogan { get; set; }
        public string Banner { get; set; }
        public string Maps { get; set; }
        public string MesajSlogan { get; set; }
        public string iletisimBaslik { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string web { get; set; }
        public string CalismaSaatleri { get; set; }
        public string Fecbook { get; set; }
        public string instegram { get; set; }
        public string Youtube { get; set; }
    }
}