using System.Web;
using System.Web.Mvc;

namespace AJAX_MVC4_APP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}