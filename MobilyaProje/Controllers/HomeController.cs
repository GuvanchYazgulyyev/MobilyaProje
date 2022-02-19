using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilyaProje.Models;

namespace MobilyaProje.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        Context cd = new Context();
        //private MailGonder email;

        [Route("/")]
        public ActionResult Index()
        {
            var deger = cd.AnaSayfas.ToList();
            return View(deger);
        }
        //İndex Hizmetler partial
        public PartialViewResult IndexHizmet()
        {
            var deger = cd.NeYapiyoruzs.ToList();
            return PartialView(deger);
        }

        //İndex Hizmetler Detay
        public ActionResult IndexHizmetDetay(int id)
        {
            var deger = cd.NeYapiyoruzs.Where(x => x.id == id).ToList();
            return View(deger);
        }

        //İndex Hizmetler Detay yan menu
        public PartialViewResult IndexHizmetDetayMenu()
        {
            var deger = cd.NeYapiyoruzs.OrderByDescending(x=>x.id).Take(1).ToList();
            return PartialView(deger);
        }

        //İndex Hizmetler Detay yan menu alt
        public PartialViewResult IndexHizmetDetayMenuAlt()
        {
            var deger = cd.NeYapiyoruzs.OrderByDescending(x => x.id).Take(4).ToList();
            return PartialView(deger);
        }

        //İndex Sürecimiz partial
        public PartialViewResult IndexSurecimiz()
        {
            var deger = cd.Surecimizs.ToList();
            return PartialView(deger);
        }
        //İndex Hizmetler partial
        public PartialViewResult IndexGaleri()
        {
            var deger = cd.Galeriiceriks.ToList();
            return PartialView(deger);
        }
        //İndex Muşteri Yorum partial
        public PartialViewResult IndexMusteriYorum()
        {
            var deger = cd.MusteriYorums.ToList();
            return PartialView(deger);
        }

        //
        //Layout Footer1 Hakkımızda
        public PartialViewResult Footer1()
        {
            var deger = cd.Hakkimizdas.OrderByDescending(x=>x.id).Take(1).ToList();
            return PartialView(deger);
        }
        //Layout Footer1 Bloklar
        public PartialViewResult Footer1Blok()
        {
            var deger = cd.Bloks.OrderByDescending(x => x.id).Take(5).ToList();
            return PartialView(deger);
        }
        //Layout Footer iletişim
        public PartialViewResult Footer1iletisim()
        {
            var deger = cd.iletisims.ToList();
            return PartialView(deger);
        }

        //
        //Layout Footer2 Sosyalmedia
        public PartialViewResult Footer2Media()
        {
            var deger = cd.iletisims.ToList();
            return PartialView(deger);
        }

        //
        //Hakkımızda Sayfası
        public ActionResult Hakkimizda()
        {
            var deger = cd.Hakkimizdas.OrderByDescending(x=>x.id).Take(1).ToList();
            return View(deger);
        }

        //Hakkımızda Sayfası Muşteri Yorumları Patial
        public PartialViewResult HakkimizdaMusteriYorum()
        {
            var deger = cd.MusteriYorums.ToList();
            return PartialView(deger);
        }

        //
        //İletişim Sayfası 
        public ActionResult iletisim()
        {
            var deger = cd.iletisims.ToList();
            return View(deger);
        }
        //iletişim Sayfası Mesaj Get
        [HttpGet]
        public PartialViewResult Mesaj()
        {
            return PartialView();
        }

        //iletişim Sayfası Mesaj post
        [HttpPost]
        public PartialViewResult Mesaj(Mesaj e)
        {
            e.Tarih = DateTime.Now;
            cd.Mesajs.Add(e);
            cd.SaveChanges();
            TempData["iletisimmesaj"] = "";
            return PartialView();
        }


        //
        //Blogler Sayfası
        public ActionResult Blog()
        {
            var deger = cd.BlokSayfas.ToList();
            return View(deger);
        }

        //Bloglar Listeleme Sayfa 
        public PartialViewResult BlogListele()
        {
            var deger = cd.Bloks.ToList();
            return PartialView(deger);
        }

        //Bloglar Listeleme Sayfası Son Postlar 
        public PartialViewResult BlogSonPost()
        {
            var deger = cd.Bloks.OrderByDescending(x=>x.id).Take(5).ToList();
            return PartialView(deger);
        }

        //Bloglar Listeleme Sayfası  Hakkımızda yan menu
        public PartialViewResult BlogHakkimizda()
        {
            var deger = cd.Hakkimizdas.ToList();
            return PartialView(deger);
        }

        //Bloglar Detay 
        public ActionResult BlogDetay(int id)
        {
            var deger = cd.Bloks.Where(x => x.id == id).ToList();
            return View(deger);
        }


        //
        // Galeri Detay 
        public ActionResult GaleriDetay(int id)
        {
            var deger = cd.Galeriiceriks.Where(x => x.id == id).ToList();
            return View(deger);
        }

        // Galeri Detay Resim
        public PartialViewResult GaleriDetayResim(int id)
        {
            var deger = cd.Galeris.Where(x => x.Galeriid == id).ToList();
            return PartialView(deger);
        }

        //İndex Referanslar
        public PartialViewResult Referans()
        {
            var deger = cd.Referans.ToList();
            return PartialView(deger);
        }

        //video
        public PartialViewResult Video()
        {
            var deger = cd.Videos.ToList();
            return PartialView(deger);
        }






        // En Üst Drop Dwn Menu Hizmetleri

        public PartialViewResult HizmetlerDropDown()
        {
            var deger = cd.NeYapiyoruzs.ToList();
            return PartialView(deger);
        }





        // Mail Yolu
        //public HomeController()
        //{
        //    email = new MailGonder();
        //}



        // Form Gönderme 

        [HttpGet]
        public ActionResult TalepOlustur()
        {
            List<SelectListItem> d2 = (from x in cd.NeYapiyoruzs.Where(l => l.Durum == true).ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.Baslik1,
                                           Value = x.id.ToString()
                                       }).ToList();
            ViewBag.dgr2 = d2;

            Random rnd = new Random();
            string[] karakterler = { "A", "B", "C", "D", "E", "F", "G", "H", "V", "Q", "W", "Z" };
            int k1, k2, k3;
            k1 = rnd.Next(0, karakterler.Length);
            k2 = rnd.Next(0, karakterler.Length);
            k3 = rnd.Next(0, karakterler.Length);
            int s1, s2, s3;
            s1 = rnd.Next(100, 1000);
            s2 = rnd.Next(10, 99);
            s3 = rnd.Next(10, 99);
            string kod = s1.ToString() + karakterler[k1] + s2 + karakterler[k2] + s3 + karakterler[k3];
            ViewBag.takipkod = kod;
            return View();
        }

        [HttpPost]
        public ActionResult TalepOlustur(FormGonder h /*string EPosta, string ProjeBaslik, string AdSoyad, string TelNo, string TakipKodu, string ileti*/)
        {

            h.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            h.Durum = true;
            cd.FormGonders.Add(h);
            cd.SaveChanges();
            //email.Mail(EPosta, ProjeBaslik, AdSoyad, TelNo, TakipKodu, ileti);
            ViewBag.Kontrol = "Başarı İle Mail Gönderildi";
            TempData["formgonder"] = "";
            return View();
        }



    }
}