using System.Web;
using System.Web.Mvc;

namespace Ticari_Web_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
          //  GlobalFilters.Filters.Add(new AuthorizeAttribute());  // program geneli authorize eklendi
        }
    }
}
