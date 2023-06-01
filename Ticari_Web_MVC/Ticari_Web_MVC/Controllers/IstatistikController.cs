using Data_Access_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ticari_Web_MVC.Models;

namespace Ticari_Web_MVC.Controllers
{
    public class IstatistikController : Controller
    {
        Context c = new Context();
        // GET: Istatistik
        public ActionResult Index()
        {
            ViewBag.dgr1 = c.caris.Count().ToString();
            ViewBag.dgr2 = c.uruns.Count().ToString();
            ViewBag.dgr3 = c.personels.Count().ToString();
            ViewBag.dgr4 = c.kategoris.Count().ToString();
            ViewBag.dgr5 = c.uruns.Sum(x => x.Stok).ToString();
            ViewBag.dgr6 = (from x in c.uruns select x.marka).Distinct().Count().ToString();
            ViewBag.dgr7 = c.uruns.Where(x => x.Stok < 20).Count().ToString();
            ViewBag.dgr8 = (from x in c.uruns orderby x.Satis_Fiyat descending select x.Urun_Ad).FirstOrDefault(); //max marka
            ViewBag.dgr9 = (from x in c.uruns orderby x.Satis_Fiyat ascending select x.Urun_Ad).FirstOrDefault();
            ViewBag.dgr10 = c.uruns.GroupBy(x => x.marka.Marka_Ad).OrderByDescending(k => k.Count()).Select(l => l.Key).FirstOrDefault();                                                              // buzd,laptop,encoksatan,kasa bugunkusatıs,bugunkukasa
            ViewBag.dgr11 = c.uruns.Count(x => x.kategori.Kategori_Ad == "buzdolabı").ToString();
            ViewBag.dgr12 = c.uruns.Count(x => x.kategori.Kategori_Ad == "laptop").ToString();
            ViewBag.dgr13 = c.uruns.Where(z => z.Urun_Id == (c.satis_Harekets.GroupBy(x => x.Urun_Id).OrderByDescending(y => y.Count()).Select(a => a.Key).FirstOrDefault())).Select(k=>k.Urun_Ad).FirstOrDefault();
            ViewBag.dgr14 = c.satis_Harekets.Sum(x => x.Toplam_Tutar).ToString();
            ViewBag.dgr15 = c.satis_Harekets.Count(x => x.Tarih == DateTime.Today).ToString() + " adet";
             ViewBag.dgr16 = c.satis_Harekets.Where(x => x.Tarih == DateTime.Today).Sum(y =>(decimal?) y.Toplam_Tutar).ToString();

            return View();
        }



        public ActionResult Basic_Tables()
        {
            Tablo_Model tm = new Tablo_Model();

          
            return View();
        }
    }
}