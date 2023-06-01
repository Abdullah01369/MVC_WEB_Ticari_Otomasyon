using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Ticari_Web_MVC.Models;

namespace Ticari_Web_MVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        Cari_Manager cm = new Cari_Manager();
        Personel_Manager pm = new Personel_Manager();   // YETKİLENDİRMEDE 1. KİŞİ HERSEYİ GOREBİLİRKEN DİGER YONETICI SADECE URUNLERE MUDAHALE EDEBİLSİN
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
     
        [HttpGet]
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Login_Model lm) // webconfig eksik
        {
            if (lm != null)
            {
                if (lm.Personel != null)
                {
                    var user = pm.Personel_Giris(lm.Personel);

                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(user.Personel_Mail, false);
                        Session["Personel_Mail"] = user.Personel_Mail;

                        return RedirectToAction("Index", "Istatistik");
                    }
                }

                else if (lm.Cari != null)
                {
                    var veri = cm.Cari_Giris(lm.Cari);
                    if (veri != null)
                    {
                        FormsAuthentication.SetAuthCookie(veri.Cari_Mail, false);
                        Session["Cari_Mail"] = veri.Cari_Mail;

                        return RedirectToAction("Index", "Cari_Panel");
                    }
                }

                else
                {
                    return RedirectToAction("Giris", "Login");
                }
            }

            return RedirectToAction("Giris", "Login");




        }
    }
}