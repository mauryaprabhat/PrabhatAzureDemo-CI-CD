using System.Web;
using System.Web.Mvc;

namespace PrabhatAzureDemo01_CI_CD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
