using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _PlarformSettings:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
