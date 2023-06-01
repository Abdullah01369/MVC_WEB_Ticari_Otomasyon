using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class DepartmanController : Controller
    {
        Personel_Manager pm = new Personel_Manager();
        Departman_Manager dm = new Departman_Manager();
        // GET: Departman
        public ActionResult Index()
        {
            var veri = dm.Departman_Listele();
            return View(veri);
        }
        [HttpGet]
        public ActionResult Departman_Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Departman_Ekle(Departman d)
        {
            dm.Departman_Ekle(d);
            return RedirectToAction("Index", "Departman");
        }


        [HttpGet]
        public ActionResult Departman_Guncelle(int id)
        {
            var veri = dm.Departman_Getir(id); // ÖNCEKİ VERİLERİ GETİRMEK İÇİN

            return View(veri);


        }
        [HttpPost]
        public ActionResult Departman_Guncelle(int id, Departman k)
        {
            var dp = dm.Departman_Getir(id);
            dp.Departman_Ad = k.Departman_Ad;
            dm.Departman_Guncelle();
            return RedirectToAction("Index", "Departman");
        }

        public ActionResult Departman_Sil(int id)
        {
            dm.Departman_Sil(id);
            return RedirectToAction("Index", "Departman");
        }
        
        public ActionResult Departman_Personel_Listele(int id) 
        {
           var veri= pm.Personel_Listele_Departman(id);
            return View(veri);
        }

       
        
    }
}