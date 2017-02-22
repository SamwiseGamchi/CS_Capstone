using System.Web;
using System.Web.Mvc;

namespace CAPSTONE_ASP_CS_WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
