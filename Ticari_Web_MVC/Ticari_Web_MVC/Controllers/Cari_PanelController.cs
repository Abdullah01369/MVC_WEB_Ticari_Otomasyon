using Businness_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Ticari_Web_MVC.Controllers
{
    public class Cari_PanelController : Controller
    {
        Cari_Manager cm = new Cari_Manager();
        Mesaj_Manager mm = new Mesaj_Manager();
        // GET: Cari_Panel
        public ActionResult Index()
        {

            var p = cm.Cari_Getir_Mail(Session["Cari_Mail"].ToString());
            ViewBag.ad_soyad = p.Cari_Ad + " " + p.Cari_Soyad;

            return View(p);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Giris","Login");
        }
      
    }
}