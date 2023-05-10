using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            return View();
        }
    }
}
