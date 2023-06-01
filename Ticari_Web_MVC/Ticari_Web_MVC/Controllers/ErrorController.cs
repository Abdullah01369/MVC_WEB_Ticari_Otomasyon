using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Error_Sayfasi()
        {
            Response.TrySkipIisCustomErrors = true;

            return View();
        }
        public ActionResult Error_Sayfasi_404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;

            return View("Error_Sayfasi");
        }
        public ActionResult Error_Sayfasi_400()
        {
            Response.StatusCode = 400;
            Response.TrySkipIisCustomErrors = true;

            return View("Error_Sayfasi");
        }
        public ActionResult Error_Sayfasi_403()
        {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;

            return View("Error_Sayfasi");
        }
    }
}