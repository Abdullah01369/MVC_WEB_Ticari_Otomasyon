using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Data_Access_Layer.Concrete;
using Ticari_Web_MVC.Models;

namespace Ticari_Web_MVC.Controllers
{
    public class GrafikController : Controller
    {
        Context c = new Context();
        // GET: Grafik
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Index3()
        {
            ArrayList xvalue = new ArrayList();
            ArrayList yvalue = new ArrayList();
            var sonuclar = c.uruns.ToList();
            sonuclar.ToList().ForEach(x => xvalue.Add(x.Urun_Ad));
            sonuclar.ToList().ForEach(y => yvalue.Add(y.Stok));
            var grafik = new Chart(width: 500, height: 500)
            .AddTitle("Stoklar")
            .AddSeries(chartType: "Column", name: "Stok", xValue: xvalue, yValues: yvalue);

            return File(grafik.ToWebImage().GetBytes(), "image/jpeg");

        }
        public ActionResult Index4()
        {
            return View();
        }
        public ActionResult VisualizeUrunResult()
        {
            return Json(UrunListesi(), JsonRequestBehavior.AllowGet);
        }



        public List<Chart_Model> UrunListesi()
        {
            List<Chart_Model> snf = new List<Chart_Model>();
            using (var c = new Context())
            {
                snf = c.uruns.Select(x => new Chart_Model
                {
                    Urunad = x.Urun_Ad,
                    Stok = x.Stok
                }).ToList();
            }
            return snf;
        }
    }
}
