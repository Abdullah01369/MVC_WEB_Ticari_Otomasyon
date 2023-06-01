using Businness_Layer.Concrete;
using Data_Access_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticari_Web_MVC.Models;

namespace Ticari_Web_MVC.Controllers
{
    public class FaturaController : Controller
    {
        Context c = new Context();
        Cari_Manager cm = new Cari_Manager();
        Fatura_Manager fm = new Fatura_Manager();
        // GET: Fatura
        public ActionResult Index()
        {

            return View(fm.Fatura_Listele());
        }

        [HttpGet]
        public ActionResult Fatura_Ekle()
        {
            List<SelectListItem> Cari_list = (from x in cm.Cari_Listele()
                                              select new SelectListItem   // dropdownliste attıık
                                              {
                                                  Text = x.Cari_Ad + " " + x.Cari_Soyad,
                                                  Value = x.Cari_Id.ToString()
                                              }).ToList();

            ViewBag.Cariliste = Cari_list;

            return View();
        }
        [HttpPost]
        public ActionResult Fatura_Ekle(Fatura fatura)
        {
            fm.Fatura_Ekle(fatura);
            return RedirectToAction("Index", "Urun");
        }

        [HttpGet]
        public ActionResult Fatura_Guncelle(int id)
        {
            List<SelectListItem> Cari_list = (from x in cm.Cari_Listele()
                                              select new SelectListItem   // dropdownliste attıık
                                              {
                                                  Text = x.Cari_Ad + " " + x.Cari_Soyad,
                                                  Value = x.Cari_Id.ToString()
                                              }).ToList();

            ViewBag.Cariliste = Cari_list;
            var veri = fm.Fatura_Getir(id);

            return View(veri);
        }
        [HttpPost]
        public ActionResult Fatura_Guncelle(int id, Fatura f)
        {
            var veri = fm.Fatura_Getir(id);
            veri.Fatura_Seri_No = f.Fatura_Seri_No;
            veri.Saat = f.Saat;

            veri.Vergi_Dairesi = f.Vergi_Dairesi;
            veri.Tarih = f.Tarih;
            veri.Toplam = f.Toplam;
            veri.Cari_Id = f.Cari_Id;

            fm.Fatura_Guncelle();
            return RedirectToAction("Index", "Fatura");
        }


        public ActionResult Fatura_Kalem_List(int id)
        {
            var liste = fm.Fatura_Kalem_List(id);
            return View(liste);
        }

        public ActionResult Fatura_Dinamik()
        {
            Fatura_Dinamik_Model fdm = new Fatura_Dinamik_Model();
            fdm.Fatura = c.faturas.ToList();
            fdm.Fatura_Kalem = c.fatura_Kalems.ToList();
            return View(fdm);
        }

        public ActionResult FaturaKaydet(string FaturaSeriNo, string FaturaSıraNo, DateTime Tarih, string VergiDairesi, string Saat, string Toplam, Fatura_Kalem[] kalemler)
        {
            Fatura f = new Fatura();
            f.Fatura_Seri_No = FaturaSeriNo;
            f.Fatura_Sira_No = FaturaSıraNo;
            f.Tarih = Tarih;
            f.Vergi_Dairesi = VergiDairesi;
            f.Saat = Saat;
            f.Cari_Id = 1;

            f.Toplam = decimal.Parse(Toplam);

            c.faturas.Add(f);

            foreach (var x in kalemler)
            {
                Fatura_Kalem fk = new Fatura_Kalem();
                fk.Aciklama = x.Aciklama;
                fk.Birim_Fiyat = x.Birim_Fiyat;
                fk.Fatura_Kalem_Id = x.Fatura_Kalem_Id;
                fk.Miktar = x.Miktar;
                fk.Tutar = x.Tutar;
                c.fatura_Kalems.Add(fk); 
}


            c.SaveChanges();
            return Json("İşlem Başarılı", JsonRequestBehavior.AllowGet);
        }
    }
}