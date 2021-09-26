using System.Web;
using System.Web.Mvc;

namespace PRG522_SUMMATIVE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
