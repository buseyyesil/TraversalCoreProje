using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout: ViewComponent

    {
        SubAboutManager subAboutManager = new SubAboutManager(new DataAccessLayer.EntityFramework.EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values=subAboutManager.TGetList();
            return View(values);
        }
    }
}
