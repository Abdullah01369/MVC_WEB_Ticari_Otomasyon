using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class SatisController : Controller
    {

        Urun_Manager um = new Urun_Manager();
        Personel_Manager pm = new Personel_Manager();
        Satis_Manager sm = new Satis_Manager();
        Cari_Manager cm = new Cari_Manager();
        // GET: Satis
        public ActionResult Index()                  //++
        {
            return View(sm.Satis_Hareket_Listele());
        }

        [HttpGet]
        public ActionResult Satis_Hareket_Ekle()   // Sessiona gore personel id gelecek, ürün eklenecek
        {
            List<SelectListItem> Urun_list = (from x in um.Urun_Listele()
                                              select new SelectListItem   // dropdownliste attıık
                                              {
                                                  Text = x.Urun_Ad,
                                                  Value = x.Urun_Id.ToString()
                                              }).ToList();

            ViewBag.Urunliste = Urun_list;

            List<SelectListItem> Cari_list = (from x in cm.Cari_Listele()
                                              select new SelectListItem   // dropdownliste attıık
                                              {
                                                  Text = x.Cari_Ad + " " + x.Cari_Soyad,
                                                  Value = x.Cari_Id.ToString()
                                              }).ToList();

            ViewBag.Cariliste = Cari_list;




            var prs = pm.Personel_Getir_Mail(Session["Personel_Mail"].ToString());
            ViewBag.personel = prs.Personel_Ad + " " + prs.Personel_Soyad;

            //List<SelectListItem> Personel_list = (from x in pm.Personel_Listele()  // SESSİONDAN ALINACAK
            //                                      select new SelectListItem   // dropdownliste attıık
            //                                      {
            //                                          Text = x.Personel_Ad + " " + x.Personel_Soyad,
            //                                          Value = x.Personel_Id.ToString()
            //                                      }).ToList();





            return View();
        }
        [HttpPost]
        public ActionResult Satis_Hareket_Ekle(Satis_Hareket satis)
        {

            satis.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            ViewBag.tarih = satis.Tarih;
            var prs = pm.Personel_Getir_Mail(Session["Personel_Mail"].ToString());
            satis.Personel_Id = prs.Personel_Id;
            sm.Satis_Hareket_Ekle(satis);

            return RedirectToAction("Index", "Satis");
        }


        [HttpGet]
        public ActionResult Satis_Hareket_Guncelle(int id)
        {


            List<SelectListItem> Urun_list = (from x in um.Urun_Listele()
                                              select new SelectListItem   // dropdownliste attıık
                                              {
                                                  Text = x.Urun_Ad,
                                                  Value = x.Urun_Id.ToString()
                                              }).ToList();

            ViewBag.Urunliste = Urun_list;

            List<SelectListItem> Cari_list = (from x in cm.Cari_Listele()
                                              select new SelectListItem   // dropdownliste attıık
                                              {
                                                  Text = x.Cari_Ad + " " + x.Cari_Soyad,
                                                  Value = x.Cari_Id.ToString()
                                              }).ToList();

            ViewBag.Cariliste = Cari_list;




            var prs = pm.Personel_Getir_Mail(Session["Personel_Mail"].ToString());
            ViewBag.personel = prs.Personel_Ad + " " + prs.Personel_Soyad;

            var veri = sm.Satis_Hareket_Getir(id);
            return View(veri);
        }
        [HttpPost]
        public ActionResult Satis_Hareket_Guncelle(int id, Satis_Hareket u)
        {

            var veri = sm.Satis_Hareket_Getir(id);
            var prs = pm.Personel_Getir_Mail(Session["Personel_Mail"].ToString());
            veri.Personel_Id = prs.Personel_Id;
           
            veri.Fiyat = u.Fiyat;
            veri.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            veri.Cari_Id = u.Cari_Id;
            veri.Adet = u.Adet;
            veri.Toplam_Tutar = u.Toplam_Tutar;
            veri.Urun_Id = u.Urun_Id;


            sm.Satis_Hareket_Guncelle();
            return RedirectToAction("Index", "Satis");
        }

        public ActionResult Satis_Hareket_Sil(int id)
        {
            sm.Satis_Hareket_Sil(id);
            return RedirectToAction("Index", "Satis");
        }
    }
}