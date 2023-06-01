using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class PersonelController : Controller
    {
        Departman_Manager dm = new Departman_Manager();
        Personel_Manager pm = new Personel_Manager();
        public ActionResult Index(string p)   // perosnel profil sayfası olusutur.
        {
            var veri = pm.Personel_Listele();

            if (!string.IsNullOrEmpty(p))
            {
                veri = veri.Where(x => x.Personel_Ad.ToLower().Contains(p.ToLower()) || x.Personel_Soyad.ToLower().Contains(p.ToLower())).ToList();

            }

            return View(veri);
        }

        [HttpGet]
        public ActionResult Personel_Ekle()
        {
            List<SelectListItem> Dep_list = (from x in dm.Departman_Listele()
                                             select new SelectListItem   // dropdownliste attıık
                                             {
                                                 Text = x.Departman_Ad,
                                                 Value = x.Departman_Id.ToString()
                                             }).ToList();

            ViewBag.departmanliste = Dep_list;
            return View();
        }
        [HttpPost]
        public ActionResult Personel_Ekle(Personel k)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/Image/" + dosyaadi+ uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                k.Personel_Gorsel = "/Image/" + dosyaadi + uzanti;
            }
            pm.Personel_Ekle(k);
            return RedirectToAction("Index", "Personel");
        }

        [HttpGet]
        public ActionResult Personel_Guncelle(int id)
        {
            List<SelectListItem> Dep_list = (from x in dm.Departman_Listele()
                                             select new SelectListItem   // dropdownliste attıık
                                             {
                                                 Text = x.Departman_Ad,
                                                 Value = x.Departman_Id.ToString()
                                             }).ToList();

            ViewBag.departmanliste = Dep_list;

            var veri = pm.Personel_Getir(id);

            return View(veri);


        }
        [HttpPost]
        public ActionResult Personel_Guncelle(int id, Personel k)
        {
            var veri = pm.Personel_Getir(id);
            veri.Personel_Ad = k.Personel_Ad;
            veri.Departman_Id = k.Departman_Id;
            veri.Personel_Gorsel = k.Personel_Gorsel;
            veri.Personel_Mail = k.Personel_Mail;
            veri.Personel_Soyad = k.Personel_Soyad;
            veri.Personel_Kayit_Tarih = k.Personel_Kayit_Tarih;
            veri.Personel_Sifre = k.Personel_Sifre;
            pm.Personel_Guncelle();
            return RedirectToAction("Index", "Personel");
        }



        public ActionResult Personel_Sil(int id)
        {
            pm.Personel_Sil(id);
            return RedirectToAction("Index", "Personel");
        }
        public ActionResult Personel_Satis(int id)
        {
            var veri = pm.Personel_Satis_Liste(id);
            ViewBag.isim = pm.Personel_Getir(id).Personel_Ad + " " + pm.Personel_Getir(id).Personel_Soyad;
            return View(veri);
        }

        public ActionResult Personel_Liste_Detay()
        {
            var veri= pm.Personel_Listele();
            return View(veri);
          
        }
    }
}