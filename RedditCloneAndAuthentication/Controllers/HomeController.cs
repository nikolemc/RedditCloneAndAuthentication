using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditCloneAndAuthentication.Models;
using RedditCloneAndAuthentication.Services;
using RedditCloneAndAuthentication.ViewModels;

namespace RedditCloneAndAuthentication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new ApplicationDbContext().Post.OrderByDescending(o => o.PostedTimeStamp).ToList();


            //if (HttpContext.User.Identity.IsAuthenticated)
            //{
            //    var name = HttpContext.User.Identity.Name;
            //    var userId = User.Identity.GetUserId();
            //}
            return View(vm);
        }


        [Authorize]
        public ActionResult RedditMember()
        {
            return View();
        }

        [Authorize]
        public ActionResult AddPost()
        {
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}