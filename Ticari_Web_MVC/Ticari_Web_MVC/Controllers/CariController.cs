using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
     // VALİDASYONLARI YAP...
    public class CariController : Controller
    {
        Cari_Manager cm = new Cari_Manager();
        // GET: Cari
        public ActionResult Index()    // ++
        {
            var veri = cm.Cari_Listele();
            return View(veri);
        }
        [HttpGet]
        public ActionResult Cari_Ekle()
        {
            List<SelectListItem> Sehir_list = (from x in cm.Sehir_Liste()
                                             select new SelectListItem   // dropdownliste attıık
                                             {
                                                 Text = x.Sehir_Ad,
                                                 Value = x.Sehir_Id.ToString()
                                             }).ToList();

            ViewBag.shrliste = Sehir_list;
            return View();
        }
        [HttpPost]
        public ActionResult Cari_Ekle(Cari d)
        {
            
            cm.Cari_Ekle(d);
            return RedirectToAction("Index", "Cari");
        }


        [HttpGet]
        public ActionResult Cari_Guncelle(int id)
        {
            List<SelectListItem> Sehir_list = (from x in cm.Sehir_Liste()
                                               select new SelectListItem   // dropdownliste attıık
                                               {
                                                   Text = x.Sehir_Ad,
                                                   Value = x.Sehir_Id.ToString()
                                               }).ToList();

            ViewBag.shrliste = Sehir_list;

            var veri = cm.Cari_Getir(id); // ÖNCEKİ VERİLERİ GETİRMEK İÇİN

            return View(veri);


        }
        [HttpPost]
        public ActionResult Cari_Guncelle(int id, Cari k)
        {
            var dp = cm.Cari_Getir(id);
            dp.Cari_Ad = k.Cari_Ad;
            dp.Cari_Soyad = k.Cari_Soyad;
            dp.Cari_Mail = k.Cari_Mail;
            dp.Sehir_Id = k.Sehir_Id;
            cm.Cari_Guncelle();
            return RedirectToAction("Index", "Cari");
        }

        public ActionResult Cari_Sil(int id)
        {
            cm.Cari_Sil(id);
            return RedirectToAction("Index", "Cari");
        }

      
    }
}