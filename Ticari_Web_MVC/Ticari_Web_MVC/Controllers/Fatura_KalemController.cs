using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class Fatura_KalemController : Controller
    {
        Fatura_Kalem_Manager fkm = new Fatura_Kalem_Manager();
        // GET: Fatura_Kalem
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Fatura_Kalem_Ekle(int id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public ActionResult Fatura_Kalem_Ekle(int id, Fatura_Kalem fk)
        {
            ViewBag.id = id;
            fk.Fatura_Id = id;
            fkm.Fatura_Kalem_Ekle(fk);

            return RedirectToAction("Index", "Fatura");
        }

        [HttpGet]
        public ActionResult Fatura_Kalem_Guncelle(int id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public ActionResult Fatura_Kalem_Guncelle(int id, Fatura_Kalem fk)
        {
            var veri = fkm.Fatura_Kalem_Getir(id);
            veri.Aciklama = fk.Aciklama;
            veri.Birim_Fiyat = fk.Birim_Fiyat;
            veri.Miktar = fk.Miktar;
            veri.Tutar = fk.Tutar;

            fkm.Fatura_Kalem_Guncelle();
            return RedirectToAction("Index", "Fatura");
        }
    }
}