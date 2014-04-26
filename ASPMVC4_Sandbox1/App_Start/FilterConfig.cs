using System.Web;
using System.Web.Mvc;

namespace ASPMVC4_Sandbox1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}