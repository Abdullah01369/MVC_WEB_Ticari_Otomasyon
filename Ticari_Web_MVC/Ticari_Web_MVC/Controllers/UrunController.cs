using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class UrunController : Controller
    {
        Marka_Manager mm = new Marka_Manager();
        Kategori_Manager km = new Kategori_Manager();
        Urun_Manager um = new Urun_Manager();
        // GET: Urun
        public ActionResult Index()
        {
            var veri = um.Urun_Listele();
            return View(veri);
        }

        [HttpGet]
        public ActionResult Urun_Ekle()
        {
            List<SelectListItem> katlist = (from x in km.Kategori_Listele()
                                            select new SelectListItem   // dropdownliste attıık
                                            {
                                                Text = x.Kategori_Ad,
                                                Value = x.Kategori_Id.ToString()
                                            }).ToList();

            ViewBag.kategoriliste = katlist;

            List<SelectListItem> m_liste = (from x in mm.Marka_Listele()
                                            select new SelectListItem   // dropdownliste marka attıık
                                            {
                                                Text = x.Marka_Ad,
                                                Value = x.Marka_Id.ToString()
                                            }).ToList();

            ViewBag.markaliste = m_liste;
            return View();
        }
        [HttpPost]
        public ActionResult Urun_Ekle(Urun urun)
        {
            if (!ModelState.IsValid)
            { return View("Urun_Ekle"); }
            
            urun.Durum = true;
            um.Urun_Ekle(urun);

            return RedirectToAction("Index", "Urun");
        }
        [HttpGet]
        public ActionResult Urun_Guncelle(int id)
        {
            List<SelectListItem> katlist = (from x in km.Kategori_Listele()
                                            select new SelectListItem   // dropdownliste attıık
                                            {
                                                Text = x.Kategori_Ad,
                                                Value = x.Kategori_Id.ToString()
                                            }).ToList();

            ViewBag.kategoriliste = katlist;

            List<SelectListItem> m_liste = (from x in mm.Marka_Listele()
                                            select new SelectListItem   // dropdownliste marka attıık
                                            {
                                                Text = x.Marka_Ad,
                                                Value = x.Marka_Id.ToString()
                                            }).ToList();

            ViewBag.markaliste = m_liste;
            var veri = um.Urun_Getir(id);
            return View(veri);
        }
        [HttpPost]
        public ActionResult Urun_Guncelle(int id,Urun u) 
        {
            var veri = um.Urun_Getir(id);
            veri.Urun_Ad = u.Urun_Ad;
            veri.Satis_Fiyat = u.Satis_Fiyat;
            veri.Alis_Fiyat = u.Alis_Fiyat;
            veri.Marka_Id = u.Marka_Id;
            veri.Stok = u.Stok;
            veri.Urun_Gorsel = u.Urun_Gorsel;
            veri.Urun_Eklenme_Tarih = u.Urun_Eklenme_Tarih;
            veri.Kategori_Id = u.Kategori_Id;
            
            um.Urun_Guncelle();
            return RedirectToAction("Index","Urun");
        }

        public ActionResult Urun_Sil(int id) 
        {
            um.Urun_Sil(id);
           return RedirectToAction("Index","Urun");
        }

        public ActionResult Urun_Liste_Cikti() 
        {
            um.Urun_Listele();
            return View(um.Urun_Listele());
        }
    }
}