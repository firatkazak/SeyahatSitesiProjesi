using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;
        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //EntityLayer'daki Comment Class'ımızdan CommentDate Property'sine zamanı atadık.
            p.CommentState = true;//Comment'in durumunu true yaptık.
            commentManager.TAdd(p);//Comment'i ekledik.
            return RedirectToAction("Index", "Destination");//Yorum eklenince Destination/Index'e yönlendirdi.
        }
    }
}
