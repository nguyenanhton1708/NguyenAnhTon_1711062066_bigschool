using System.Web;
using System.Web.Mvc;

namespace NguyenAnhTon_1711062066
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
