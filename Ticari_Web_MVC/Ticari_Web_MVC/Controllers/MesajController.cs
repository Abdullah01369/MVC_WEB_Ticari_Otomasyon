using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class MesajController : Controller
    {
        Cari_Manager cm = new Cari_Manager();
        Mesaj_Manager mm = new Mesaj_Manager();
        // GET: Mesaj
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mesajlar()
        {
            var p = mm.Mesaj_Listele_Mail(Session["Cari_Mail"].ToString());
            return View(p);

        }
        public ActionResult Mesajlar_Giden()
        {
            var p = mm.Mesaj_Listele_Mail_Giden(Session["Cari_Mail"].ToString());
            return View(p);
        }

        public ActionResult Mesaj_Detay(int id)
        {

            return View(mm.Mesaj_Detay_Getir(id));

        }
        [HttpGet]
        public ActionResult Mesaj_Gonder_Cari()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Mesaj_Gonder_Cari(Mesaj m)
        {
            var kisi = cm.Cari_Getir_Mail(Session["Cari_Mail"].ToString());
            ViewBag.Mail_Mesaj = kisi.Cari_Mail;
            m.Gonderici = kisi.Cari_Mail;
            m.Tarih = DateTime.Now;
            
            mm.Mesaj_Gonder(m);
            return View();

        }
    }
}