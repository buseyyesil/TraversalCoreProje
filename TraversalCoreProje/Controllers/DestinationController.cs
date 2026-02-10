using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous] //Bu sayfaya herkes erişebilir anlamına gelir. Yani kullanıcı girişi yapmadan da bu sayfaya erişebilirler.
    public class DestinationController : Controller
    {
        DestinationManager destinationManager= new DestinationManager(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;
        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values=destinationManager.TGetList();
            return View(values);
        }

        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;

            var values = destinationManager.TGetDestinationWithGuide(id); // Guide include'lu çek
            return View(values);
        }





    }
}
