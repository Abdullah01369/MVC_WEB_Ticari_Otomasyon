using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    
    public class KategoriController : Controller
    {

        Kategori_Manager km = new Kategori_Manager();
        // GET: Kategori
        public ActionResult Index(int sayfa = 1)
        {
            var veri = km.Kategori_Listele();
            return View(veri.ToPagedList(sayfa, 4));
        }

        [HttpGet]
        public ActionResult Kategori_Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kategori_Ekle(Kategori k)
        {
            km.Kategori_Ekle(k);
            return RedirectToAction("Index", "Kategori");
        }

        [HttpGet]
        public ActionResult Kategori_Guncelle(int id)
        {
            var veri = km.Kategori_Getir(id);

            return View(veri);


        }
        [HttpPost]
        public ActionResult Kategori_Guncelle(int id, Kategori k)
        {
            var ctgry = km.Kategori_Getir(id);
            ctgry.Kategori_Ad = k.Kategori_Ad;
            km.Kategori_Guncelle();
            return RedirectToAction("Index", "Kategori");
        }



        public ActionResult Kategori_Sil(int id)
        {
            km.Kategori_Sil(id);
            return RedirectToAction("Index", "Kategori");
        }

    }
}