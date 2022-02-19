using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobilyaProje.Models
{
    public class FormGonder
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Ad Soyan Zorunlu!!!")]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage = "E Posta Zorunlu!!!")]
        public string EPosta { get; set; }
        [Required(ErrorMessage = "Tel No Zorunlu!!!")]
        public string TelNo { get; set; }

        public string TakipKodu { get; set; }
        [Required(ErrorMessage = "Proje başlığı Zorunlu!!!")]
        public string ProjeBaslik { get; set; }

        public int Hizmetid { get; set; }
        public DateTime Tarih { get; set; }

        public string ileti { get; set; }
        public bool Durum { get; set; }
        public virtual NeYapiyoruz NeYapiyoruz { get; set; }
        //public virtual ICollection<Notlar> Notlar { get; set; }
    }
}