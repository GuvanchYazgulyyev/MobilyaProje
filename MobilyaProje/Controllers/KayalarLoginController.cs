using MobilyaProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MobilyaProje.Controllers
{
    [AllowAnonymous]
    public class KayalarLoginController : Controller
    {
        // GET: KayalarLogin
        Context dr = new Context();
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AdminLogin(Admin a)
        {

            var deger = dr.Admins.FirstOrDefault(f => f.Kullanici == a.Kullanici && f.Sifre == a.Sifre);
            if (deger != null)
            {
                FormsAuthentication.SetAuthCookie(deger.Kullanici, false);
                Session["Kullanici"] = deger.Kullanici.ToString();
                ModelState.AddModelError("DateOfBirth", "2016 ve sonrasını seçiniz");
                ModelState.AddModelError("", "Lütfen hataları gideriniz.");
                return RedirectToAction("Index", "KPanel");
            }

            else
            {
                ViewBag.hata = "Hatalı Giriş!!!";
                return RedirectToAction("Index", "KayalarLogin");
            }


        }

    }
}