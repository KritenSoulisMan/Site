using System.Web.Mvc;

namespace Type_D
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Здесь вы можете зарегистрировать глобальные фильтры
            filters.Add(new HandleErrorAttribute());
        }
    }
}
