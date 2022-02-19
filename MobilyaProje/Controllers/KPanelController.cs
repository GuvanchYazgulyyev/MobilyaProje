using MobilyaProje.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace MobilyaProje.Controllers
{
    [Authorize]
    public class KPanelController : Controller
    {
        Context dr = new Context();
        // GET: KPanel
        public ActionResult Index()
        {
            var mail = (string)Session["Kullanici"];

            var adsoyad = dr.Admins.Where(x => x.Kullanici == mail).Select(k => k.AdSoyad).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;



            var is2 = dr.Hizmetlers.Count().ToString();
            ViewBag.d2 = is2;

            var is3 = dr.MusteriYorums.Count().ToString();
            ViewBag.d3 = is3;

            var is4 = dr.Bloks.Count().ToString();
            ViewBag.d4 = is4;

            var is5 = dr.Mesajs.Count().ToString();
            ViewBag.d5 = is5;


            return View();
        }

        ///-----------------------------------------------------------------
        ///--------------------------------------------------Kullanıcı Güncelle Ekle Sil 
        ///
        ///-----------
        ///
        public ActionResult Adminkullanici()
        {
            //var value = dr.Bloglar.Where(d => d.Durum == true).ToList();
            var value33 = dr.Admins.ToList();

            return View(value33);
        }



        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdminKulEkle()
        {

            return View();
        }


        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdminKulEkle(Admin u)
        {
            //if (ModelState.IsValid)
            //{
            //}

            dr.Admins.Add(u);
            dr.SaveChanges();
            return RedirectToAction("Adminkullanici");

            //return View();
        }

        ////  Sil
        ///
        public ActionResult AdminKulSil(int id)
        {
            var urnsil = dr.Admins.Find(id);
            dr.Admins.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("Adminkullanici");
        }


        // Getir

        public ActionResult AdminKulGetr(int id)
        {

            var urngetr = dr.Admins.Find(id);
            return View("AdminKulGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmKulGuncelle(Admin u)
        {

            var value = dr.Admins.Find(u.id);
            value.Kullanici = u.Kullanici;
            value.Sifre = u.Sifre;
            value.AdSoyad = u.AdSoyad;

            //value.AdminYetki.id = u.id;
            dr.SaveChanges();
            return RedirectToAction("Adminkullanici");
        }














        ///////////////////////////////---------------------------------------------- Ana sayfa Bilgi Ekle Güncelle Sil
        ///

        public ActionResult AdmAnaSayfaBilgi()
        {
            var value33 = dr.AnaSayfas.OrderByDescending(l => l.id).ToList();

            //var value = dr.Hizmetler.Where(d => d.Durum == true).ToList();
            return View(value33);
        }



        // Getir

        public ActionResult AdmAnaSayfaBilgiGetir(int id)
        {


            var urngetr = dr.AnaSayfas.Find(id);
            return View("AdmAnaSayfaBilgiGetir", urngetr);
        }

        // Güncellle

        public ActionResult AdmAnaSayfaBilgiGuncel(AnaSayfa u, HttpPostedFileBase File, HttpPostedFileBase File1, HttpPostedFileBase File2)
        {



            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Banner = "/Resim/" + uzanti;

            }


            if (File1 != null)
            {
                FileInfo fileinfo = new FileInfo(File1.FileName);
                WebImage img = new WebImage(File1.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Banner1 = "/Resim/" + uzanti;

            }


            if (File2 != null)
            {
                FileInfo fileinfo = new FileInfo(File2.FileName);
                WebImage img = new WebImage(File2.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Banner2 = "/Resim/" + uzanti;

            }






            var value = dr.AnaSayfas.Find(u.id);
            if (u.Banner != null)
            {
                value.Banner = u.Banner;
            }

            if (u.Banner1 != null)
            {
                value.Banner1 = u.Banner1;
            }

            if (u.Banner2 != null)
            {
                value.Banner2 = u.Banner2;
            }

            value.SloganKucuk = u.SloganKucuk;
            value.SloganKucuk1 = u.SloganKucuk1;
            value.SloganKucuk2 = u.SloganKucuk2;

            value.SloganBuyuk = u.SloganBuyuk;
            value.SloganBuyuk1 = u.SloganBuyuk1;
            value.SloganBuyuk2 = u.SloganBuyuk2;

            value.NeYapiyoruzBaslik = u.NeYapiyoruzBaslik;
            value.SurecimizBaslik = u.SurecimizBaslik;
            value.YorumBalik = u.YorumBalik;
            dr.SaveChanges();
            return RedirectToAction("AdmAnaSayfaBilgi");

        }










        // Bloglar 

        public ActionResult AdminBlog()
        {
            var value = dr.Bloks.OrderByDescending(l => l.id).ToList();
            return View(value);
        }


        [HttpGet]
        public ActionResult AdminBEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AdminBEkle(Blok b, HttpPostedFileBase File)
        {
            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                b.Resim = "/Resim/" + uzanti;

            }

            dr.Bloks.Add(b);
            dr.SaveChanges();
            return RedirectToAction("AdminBlog");
        }

        // Blog Sil
        public ActionResult AdminBSil(int id)
        {
            var blgsil = dr.Bloks.Find(id);
            dr.Bloks.Remove(blgsil);
            dr.SaveChanges();
            return RedirectToAction("AdminBlog");
        }

        // Blog Getir

        public ActionResult AdminBGetir(int id)
        {
            var blggetr = dr.Bloks.Find(id);
            return View("AdminBGetir", blggetr);
        }


        // Blog Güncelle

        public ActionResult UrunGuncelle(Blok b, HttpPostedFileBase File)
        {

            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                b.Resim = "/Resim/" + uzanti;

            }


            var deger = dr.Bloks.Find(b.id);

            deger.Baslik = b.Baslik;
            deger.icerik = b.icerik;
            deger.icerik1 = b.icerik1;
            deger.icerik2 = b.icerik2;
            if (b.Resim != null)
            {
                deger.Resim = b.Resim;
            }
            deger.Gun = b.Gun;
            deger.Ay = b.Ay;

            dr.SaveChanges();
            return RedirectToAction("AdminBlog");

        }









        /// blog Sayfası   Resimli Kısmı
        /// 

        public ActionResult AdmBlogBannerResim()
        {
            var de = dr.BlokSayfas.ToList();
            return View(de);
        }



        // Bilgi getir
        public ActionResult AdmBlogBannerResimGetir(int id)
        {
            var degerler = dr.BlokSayfas.Find(id);
            return View("AdmBlogBannerResimGetir", degerler);
        }


        // Blog Güncelle

        public ActionResult AdmBlogBannerResimGuncelle(BlokSayfa b, HttpPostedFileBase File)
        {
            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                b.Banner = "/Resim/" + uzanti;

            }

            var deger = dr.BlokSayfas.Find(b.id);

            deger.Slogan = b.Slogan;

            if (b.Banner != null)
            {
                deger.Banner = b.Banner;
            }

            dr.SaveChanges();
            return RedirectToAction("AdmBlogBannerResim");

        }










        /////////////////////////////////---------------------------------------------- Galeri içerik
        /////

        public ActionResult AdmHGaleriicerik()
        {
            var value33 = dr.Galeriiceriks.OrderByDescending(l => l.id).ToList();

            //var value = dr.Hizmetler.Where(d => d.Durum == true).ToList();
            return View(value33);
        }



        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmHGaleriicerikEkle()
        {
            return View();
        }


        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmHGaleriicerikEkle(Galeriicerik u, HttpPostedFileBase File)
        {
            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }




            if (u.Resim != null)
            {
                u.Resim = u.Resim;
            }
            dr.Galeriiceriks.Add(u);
            dr.SaveChanges();
            return RedirectToAction("AdmHGaleriicerik");


        }

        ////// Hizmet Sil
        /////
        public ActionResult AdmHGaleriicerikSil(int id)
        {
            var urnsil = dr.Galeriiceriks.Find(id);
            dr.Galeriiceriks.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmHGaleriicerik");
        }


        // Getir

        public ActionResult AdmHGaleriicerikGetir(int id)
        {


            var urngetr = dr.Galeriiceriks.Find(id);
            return View("AdmHGaleriicerikGetir", urngetr);
        }

        //// Güncellle

        public ActionResult AdmHGaleriicerikGuncelle(Galeriicerik u, HttpPostedFileBase File)
        {

            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }

            var value = dr.Galeriiceriks.Find(u.id);
            if (u.Resim != null)
            {
                value.Resim = u.Resim;
            }

            value.Baslik = u.Baslik;
            value.Tarih = u.Tarih;
            value.Konum = u.Konum;
            value.Deger = u.Deger;
            value.Musteri = u.Musteri;
            value.Kategori = u.Kategori;
            value.icerik = u.icerik;
            value.AltBaslik = u.AltBaslik;
            value.icerik1 = u.icerik1;
            dr.SaveChanges();
            return RedirectToAction("AdmHGaleriicerik");

        }

















        /////////////////////////////////---------------------------------------------- Galeri Resim Yükleme Kısmı
        /////

        public ActionResult AdmGaleriResim()
        {
            var value33 = dr.Galeris.OrderByDescending(l => l.id).ToList();

            //var value = dr.Hizmetler.Where(d => d.Durum == true).ToList();
            return View(value33);
        }



        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmGaleriResimEkle()
        {
            List<SelectListItem> d1 = (from x in dr.Galeriiceriks.ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.Baslik,
                                           Value = x.id.ToString()
                                       }).ToList();
            ViewBag.dgr1 = d1;
            return View();
        }


        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmGaleriResimEkle(Galeri u, HttpPostedFileBase File)
        {
            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }


            if (u.Resim != null)
            {
                u.Resim = u.Resim;
            }
            dr.Galeris.Add(u);
            dr.SaveChanges();
            return RedirectToAction("AdmGaleriResim");


        }

        ////// Hizmet Sil
        /////
        public ActionResult AdmGaleriResimSil(int id)
        {
            var urnsil = dr.Galeris.Find(id);
            dr.Galeris.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmGaleriResim");
        }


        // Getir

        public ActionResult AdmGaleriResimGetir(int id)
        {


            List<SelectListItem> d1 = (from x in dr.Galeriiceriks.ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.Baslik,
                                           Value = x.id.ToString()
                                       }).ToList();
            ViewBag.dgr1 = d1;


            var urngetr = dr.Galeris.Find(id);
            return View("AdmGaleriResimGetir", urngetr);
        }

        //// Güncellle

        public ActionResult AdmGaleriResimGuncelle(Galeri u, HttpPostedFileBase File)
        {

            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }


            var value = dr.Galeris.Find(u.id);

            if (u.Resim != null)
            {
                value.Resim = u.Resim;
            }
            value.Resim = u.Resim;
            value.Galeriid = u.Galeriid;

            dr.SaveChanges();
            return RedirectToAction("AdmGaleriResim");

        }







        // -----------------------------------------Hakkımda Bilgi Kısmı

        [HttpGet]
        public ActionResult HakkimizdaEkle()
        {
            return View();
        }


        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult HakkimizdaEkle(Hakkimizda u)
        {
            if (Request.Files.Count > 0)
            {
                if (u.Resim != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    u.Resim = "/Resim/" + dosyaad + uzanti;
                }
            }

            if (Request.Files.Count > 0)
            {
                if (u.Banner != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[1].FileName);
                    string uzanti = Path.GetExtension(Request.Files[1].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[1].SaveAs(Server.MapPath(yol));
                    u.Banner = "/Resim/" + dosyaad + uzanti;
                }
            }



            if (u.Resim != null)
            {
                u.Resim = u.Resim;
            }
            if (u.Banner != null)
            {
                u.Banner = u.Banner;
            }


            dr.Hakkimizdas.Add(u);
            dr.SaveChanges();
            return RedirectToAction("AdiminHakYazi");


        }



        public ActionResult AdiminHakYazi()
        {
            var value = dr.Hakkimizdas.ToList();
            return View(value);
        }

        //public ActionResult AdminHakSil(int id)
        //{
        //    var value = dr.Hakkimizdas.Find(id);
        //    dr.Hakkimizdas.Remove(value);
        //    dr.SaveChanges();
        //    return RedirectToAction("AdiminHakYazi");
        //}

        public ActionResult AdminHakGetir(int id)
        {
            var value = dr.Hakkimizdas.Find(id);
            return View("AdminHakGetir", value);
        }

        public ActionResult AdminHakguncelle(Hakkimizda h, HttpPostedFileBase File, HttpPostedFileBase File1)
        {
            // Buraya resim eklenecek
            // resim1
            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                h.Banner = "/Resim/" + uzanti;

            }

            // Resim2

            if (File1 != null)
            {
                FileInfo fileinfo = new FileInfo(File1.FileName);
                WebImage img = new WebImage(File1.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                h.Resim = "/Resim/" + uzanti;

            }

            var value = dr.Hakkimizdas.Find(h.id);

            value.Slogan = h.Slogan;
            value.Baslik = h.Baslik;
            value.icerik = h.icerik;

            if (h.Resim != null)
            {
                value.Resim = h.Resim;
            }



            if (h.Banner != null)
            {
                value.Banner = h.Banner;
            }
            dr.SaveChanges();
            return RedirectToAction("AdiminHakYazi");
        }
















        /////////////////////////////////---------------------------------------------- Hizmetler 
        /////

        public ActionResult AdmHizmetler()
        {
            var value33 = dr.Hizmetlers.OrderByDescending(l => l.id).ToList();

            //var value = dr.Hizmetler.Where(d => d.Durum == true).ToList();
            return View(value33);
        }



        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmHizmetlerEkle()
        {
            return View();
        }


        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmHizmetlerEkle(Hizmetler u)
        {
            if (Request.Files.Count > 0)
            {
                if (u.Resim != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    u.Resim = "/Resim/" + dosyaad + uzanti;
                }
            }

            if (Request.Files.Count > 0)
            {
                if (u.Resim1 != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[1].FileName);
                    string uzanti = Path.GetExtension(Request.Files[1].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[1].SaveAs(Server.MapPath(yol));
                    u.Resim1 = "/Resim/" + dosyaad + uzanti;
                }
            }

            if (Request.Files.Count > 0)
            {
                if (u.Resim2 != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[2].FileName);
                    string uzanti = Path.GetExtension(Request.Files[2].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[2].SaveAs(Server.MapPath(yol));
                    u.Resim2 = "/Resim/" + dosyaad + uzanti;
                }
            }

            if (u.Resim != null)
            {
                u.Resim = u.Resim;
            }
            if (u.Resim1 != null)
            {
                u.Resim1 = u.Resim1;
            }

            if (u.Resim2 != null)
            {
                u.Resim2 = u.Resim2;
            }
            dr.Hizmetlers.Add(u);
            dr.SaveChanges();
            return RedirectToAction("AdmHizmetler");


        }

        ////// Hizmet Sil
        /////
        public ActionResult AdmHizmetlerSil(int id)
        {
            var urnsil = dr.Hizmetlers.Find(id);
            dr.Hizmetlers.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmHizmetler");
        }


        // Getir

        public ActionResult AdmHizmetlerGetir(int id)
        {
            var urngetr = dr.Hizmetlers.Find(id);
            return View("AdmHizmetlerGetir", urngetr);
        }

        //// Güncellle

        public ActionResult AdmHizmetlerGuncelle(Hizmetler u)
        {

            if (Request.Files.Count > 0)
            {
                if (u.Resim != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    u.Resim = "/Resim/" + dosyaad + uzanti;
                }
            }

            if (Request.Files.Count > 0)
            {
                if (u.Resim1 != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[1].FileName);
                    string uzanti = Path.GetExtension(Request.Files[1].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[1].SaveAs(Server.MapPath(yol));
                    u.Resim1 = "/Resim/" + dosyaad + uzanti;
                    //u.iconResim = "/Resim/" + dosyaad + uzanti;
                }
            }
            if (Request.Files.Count > 0)
            {
                if (u.Resim2 != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[2].FileName);
                    string uzanti = Path.GetExtension(Request.Files[2].FileName);
                    string yol = "~/Resim/" + dosyaad + uzanti;
                    Request.Files[2].SaveAs(Server.MapPath(yol));
                    u.Resim2 = "/Resim/" + dosyaad + uzanti;
                    //u.iconResim = "/Resim/" + dosyaad + uzanti;
                }
            }

            var value = dr.Hizmetlers.Find(u.id);
            value.Slogan = u.Slogan;// Hata alıyorum
            value.Baslik = u.Baslik;
            value.icerik = u.icerik;
            if (u.Resim != null)
            {
                value.Resim = u.Resim;
            }

            if (u.Resim1 != null)
            {
                value.Resim1 = u.Resim1;
            }

            if (u.Resim2 != null)
            {
                value.Resim2 = u.Resim2;
            }
            dr.SaveChanges();
            return RedirectToAction("AdmHizmetler");

        }





        //}

        /////----------------------------------------------------------------İletişim (Bilgi)-----//////
        /////

        public ActionResult AdmiletsmBilgi()
        {
            var value33 = dr.iletisims.ToList();

            return View(value33);
        }




        // Getir

        public ActionResult AdmiltGetr(int id)
        {


            var urngetr = dr.iletisims.Find(id);
            return View("AdmiltGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmiltGuncelle(iletisim u)
        {


            if (Request.Files.Count > 0)
            {
                if (u.Banner != null)
                {
                    string dosyaad = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Resim/" + dosyaad;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    u.Banner = "/Resim/" + dosyaad + uzanti;
                }
            }


            var value = dr.iletisims.Find(u.id);
            value.Slogan = u.Slogan;
            if (u.Banner != null)
            {
                value.Banner = u.Banner;
            }
            value.Maps = u.Maps;
            value.MesajSlogan = u.MesajSlogan;
            value.iletisimBaslik = u.iletisimBaslik;
            value.Adres = u.Adres;
            value.Telefon = u.Telefon;
            value.Eposta = u.Eposta;
            value.web = u.web;
            value.CalismaSaatleri = u.CalismaSaatleri;
            value.Fecbook = u.Fecbook;
            value.instegram = u.instegram;
            value.Youtube = u.Youtube;

            dr.SaveChanges();
            return RedirectToAction("AdmiletsmBilgi");
        }







        /////----------------------------------------------------------------İletişim (Gelen Mesaj)-----//////
        /////

        public ActionResult AdmiletsmGMesaj(string p)
        {

            var urngtr = from x in dr.Mesajs.OrderByDescending(l => l.id) select x;
            if (!string.IsNullOrEmpty(p))
            {
                urngtr = urngtr.Where(x => x.Eposta.Contains(p));
            }
            return View(urngtr.ToList());
        }

        ////  Sil
        ///
        public ActionResult AdmMesjSil(int id)
        {
            var urnsil = dr.Mesajs.Find(id);
            dr.Mesajs.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmiletsmGMesaj");
        }


        // Getir

        public ActionResult AdmMesjGetr(int id)
        {
            var urngetr = dr.Mesajs.Find(id);
            return View("AdmMesjGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmMesjGuncelle(Mesaj u)
        {
            var value = dr.Mesajs.Find(u.id);
            //value.AdSoyad = u.AdSoyad;
            //value.Eposta = u.Eposta;
            //value.Telefon = u.Telefon;
            value.Mesajicerik = u.Mesajicerik;
            dr.SaveChanges();
            return RedirectToAction("AdmiletsmGMesaj");
        }















        /////----------------------------------------------------------------------------------------------------//

        ///////////////------------------- Müşteri Referansları
        /////

        public ActionResult AdmMutMusYorum()
        {
            var value33 = dr.MusteriYorums.OrderByDescending(x => x.id).ToList();
            return View(value33);
        }
        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmMutMusEkle()
        {

            return View();
        }
        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmMutMusEkle(MusteriYorum u)
        {
            dr.MusteriYorums.Add(u);
            dr.SaveChanges();
            return RedirectToAction("AdmMutMusYorum");
        }

        ////  Sil
        ///
        public ActionResult AdmMutMusSil(int id)
        {
            var urnsil = dr.MusteriYorums.Find(id);
            dr.MusteriYorums.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmMutMusYorum");
        }


        // Getir

        public ActionResult AdmMutMusGetr(int id)
        {


            var urngetr = dr.MusteriYorums.Find(id);
            return View("AdmMutMusGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmMutMusGuncelle(MusteriYorum u)
        {

            var value = dr.MusteriYorums.Find(u.id);
            value.Yorum = u.Yorum;
            value.AdSoyad = u.AdSoyad;
            dr.SaveChanges();
            return RedirectToAction("AdmMutMusYorum");
        }












        /////----------------------------------------------------------------------------------------------------//

        ///////////////------------------- Müşteri Hizmetler
        /////

        public ActionResult AdmNeYapiyoruz()
        {
            var value33 = dr.NeYapiyoruzs.OrderByDescending(x => x.id).ToList();
            return View(value33);
        }
        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmNeYapiyoruzEkle()
        {

            return View();
        }
        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmNeYapiyoruzEkle(NeYapiyoruz u, HttpPostedFileBase File, HttpPostedFileBase File1)
        {

            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }

            dr.NeYapiyoruzs.Add(u);
            if (u.Resim != null)
            {
                u.Resim = u.Resim;
            }

            //resim 2
            if (File1 != null)
            {
                FileInfo fileinfo = new FileInfo(File1.FileName);
                WebImage img = new WebImage(File1.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim1 = "/Resim/" + uzanti;

            }


            dr.NeYapiyoruzs.Add(u);
            if (u.Resim1 != null)
            {
                u.Resim1 = u.Resim1;
            }
            u.Durum = true;
            dr.SaveChanges();
            return RedirectToAction("AdmNeYapiyoruz");
        }



        ////  Sil
        ///
        public ActionResult AdmNeYapiyoruzSil(int id)
        {
            var urnsil = dr.NeYapiyoruzs.Find(id);
            urnsil.Durum = false;
            dr.SaveChanges();
            return RedirectToAction("AdmNeYapiyoruz");
        }


        // Getir

        public ActionResult AdmNeYapiyoruzGetr(int id)
        {


            var urngetr = dr.NeYapiyoruzs.Find(id);
            return View("AdmNeYapiyoruzGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmNeYapiyoruzGuncelle(NeYapiyoruz u, HttpPostedFileBase File, HttpPostedFileBase File1)
        {
            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }


            if (File1 != null)
            {
                FileInfo fileinfo = new FileInfo(File1.FileName);
                WebImage img = new WebImage(File1.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim1 = "/Resim/" + uzanti;

            }

            var value = dr.NeYapiyoruzs.Find(u.id);
            if (u.Resim != null)
            {
                value.Resim = u.Resim;
            }
            if (u.Resim1 != null)
            {
                value.Resim1 = u.Resim1;
            }


            //value.Baslik = u.Baslik;
            value.Baslik1 = u.Baslik1;
            value.icerik = u.icerik;
            value.Durum = true;
            dr.SaveChanges();
            return RedirectToAction("AdmNeYapiyoruz");
        }












        /////----------------------------------------------------------------------------------------------------//

        ///////////////------------------- Sürecimiz Kısmı
        /////

        public ActionResult AdmSurecimiz()
        {
            var value33 = dr.Surecimizs.OrderByDescending(x => x.id).ToList();
            return View(value33);
        }
        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmSurecimizEkle()
        {

            return View();
        }
        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmSurecimizEkle(Surecimiz u)
        {
            dr.Surecimizs.Add(u);
            dr.SaveChanges();
            return RedirectToAction("AdmSurecimiz");
        }



        ////  Sil
        ///
        public ActionResult AdmSurecimizSil(int id)
        {
            var urnsil = dr.Surecimizs.Find(id);
            dr.Surecimizs.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmSurecimiz");
        }


        // Getir

        public ActionResult AdmSurecimizGetr(int id)
        {


            var urngetr = dr.Surecimizs.Find(id);
            return View("AdmSurecimizGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmSurecimizGuncelle(Surecimiz u)
        {

            var value = dr.Surecimizs.Find(u.id);

            value.Surec = u.Surec;
            value.icerik = u.icerik;
            value.Surec1 = u.Surec1;
            value.icerik1 = u.icerik1;
            value.Surec2 = u.Surec2;
            value.iceri2 = u.iceri2;
            value.Surec3 = u.Surec3;
            value.icerik3 = u.icerik3;
            dr.SaveChanges();
            return RedirectToAction("AdmSurecimiz");
        }





        ///-----------------------------------------------------------------Çıkış (Log Out)
        ///
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "KayalarLogin");
        }
















        ///--------------------------------------------------------Referans Resimler-----------///
        ///

        public ActionResult AdmReferans()
        {
            //var value = dr.Bloglar.Where(d => d.Durum == true).ToList();
            var value33 = dr.Referans.ToList();

            return View(value33);
        }

        ////  Sil
        ///
        public ActionResult AdmRefSil(int id)
        {
            var urnsil = dr.Referans.Find(id);
            dr.Referans.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmReferans");
        }

        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmRefEkle()
        {

            return View();
        }


        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmRefEkle(Referans u, HttpPostedFileBase File)
        {



            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }

            dr.Referans.Add(u);
            if (u.Resim != null)
            {
                u.Resim = u.Resim;
            }
            dr.SaveChanges();
            return RedirectToAction("AdmReferans");
        }


        // Getir

        public ActionResult AdmRefGetr(int id)
        {


            var urngetr = dr.Referans.Find(id);
            return View("AdmRefGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmRefGuncelle(Referans u, HttpPostedFileBase File)
        {



            if (File != null)
            {
                FileInfo fileinfo = new FileInfo(File.FileName);
                WebImage img = new WebImage(File.InputStream);
                string uzanti = (Guid.NewGuid().ToString() + fileinfo.Extension).ToLower();
                //img.Resize(225, 180, false, false);
                string tamyol = "~/Resim/" + uzanti;
                img.Save(Server.MapPath(tamyol));
                u.Resim = "/Resim/" + uzanti;

            }




            var value = dr.Referans.Find(u.id);
            if (u.Resim != null)
            {
                value.Resim = u.Resim;
            }


            dr.SaveChanges();
            return RedirectToAction("AdmReferans");



        }



        ////------------------------------------------------------------Hizmet Formu
        ///// Arama Yapma Kısmı--------------------------------------------------------------------
        public ActionResult AdminHizForm(string p)
        {

            var urngtr = from x in dr.FormGonders.Where(k => k.Durum == true).OrderByDescending(l => l.id) select x;
            if (!string.IsNullOrEmpty(p))
            {
                urngtr = urngtr.Where(x => x.TakipKodu.Contains(p));
            }
            return View(urngtr.ToList());


            //var value = dr.HizmetForm.Where(d => d.Durum == true).ToList();
            //return View(value);
        }




        //////  Sil
        ///// <summary>
        ///// 
        //[Authorize(Roles = "Admin")]
        public ActionResult AdminHFormSil(int id)
        {
            var urnsil = dr.FormGonders.Find(id);
            urnsil.Durum = false;
            dr.SaveChanges();
            return RedirectToAction("AdminHizForm");
        }


        // Getir

        public ActionResult AdminHiFormGetir(int id)
        {
        

            List<SelectListItem> d2 = (from x in dr.NeYapiyoruzs.Where(d => d.Durum == true).ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.Baslik1,
                                           Value = x.id.ToString()
                                       }).ToList();
            ViewBag.dgr2 = d2;

            var urngetr = dr.FormGonders.Find(id);
            return View("AdminHiFormGetir", urngetr);
        }

        // Güncellle
        //[Authorize(Roles = "Admin")]
        public ActionResult AdmHizFormGuncel(FormGonder u)
        {
            var value = dr.FormGonders.Find(u.id);
            value.AdSoyad = u.AdSoyad;
            value.AdSoyad = u.AdSoyad;
            value.EPosta = u.EPosta;
            value.TelNo = u.TelNo;
            value.ProjeBaslik = u.ProjeBaslik;
            //value.Kategoriid = u.Kategoriid;
            value.Hizmetid = u.Hizmetid;
            value.ileti = u.ileti;
            dr.SaveChanges();
            return RedirectToAction("AdminHizForm");
        }







        ///--------------------------------------------------------AdmVideo   Vide Ekle  Sil-----------///
        ///

        public ActionResult AdmVideo()
        {
            //var value = dr.Bloglar.Where(d => d.Durum == true).ToList();
            var value33 = dr.Videos.ToList();

            return View(value33);
        }

        ////  Sil
        ///
        public ActionResult AdmVideoSil(int id)
        {
            var urnsil = dr.Videos.Find(id);
            dr.Videos.Remove(urnsil);
            dr.SaveChanges();
            return RedirectToAction("AdmVideo");
        }

        ///// Ekle
        ///

        [HttpGet]
        public ActionResult AdmVideoEkle()
        {

            return View();
        }


        // Veriler geldiginde HttpPost çalışır
        [HttpPost]
        public ActionResult AdmVideoEkle(Video u)
        {


            dr.Videos.Add(u); 
            dr.SaveChanges();
            return RedirectToAction("AdmVideo");
        }


        // Getir

        public ActionResult AdmVideoGetr(int id)
        {


            var urngetr = dr.Videos.Find(id);
            return View("AdmVideoGetr", urngetr);
        }

        // Güncellle

        public ActionResult AdmVideoGuncelle(Video u)
        {


            var value = dr.Videos.Find(u.id);
            value.Media = u.Media;
            value.Resim = u.Resim;

            dr.SaveChanges();
            return RedirectToAction("AdmVideo");



        }



    }
}