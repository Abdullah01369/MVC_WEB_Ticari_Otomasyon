using Businness_Layer.Concrete;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class KargoController : Controller
    {
        Kargo_Manager km = new Kargo_Manager();

        // GET: Kargo
        public ActionResult Index()
        {
            return View(km.Kargo_Listele());
        }

        [HttpGet]
        public ActionResult Kargo_Ekle() 
        {
            return View();

        }
        [HttpPost]
        public ActionResult Kargo_Ekle(Kargo k)
        {
           
            return View();

        }
    }
}