using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
