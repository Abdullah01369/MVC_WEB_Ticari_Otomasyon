using Businness_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class GaleriController : Controller
    {
        Urun_Manager um = new Urun_Manager();
        // GET: Galeri
        public ActionResult Index()
        {
            return View(um.Urun_Listele());
        }
    }
}