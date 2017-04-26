using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditCloneAndAuthentication.Models;

namespace RedditCloneAndAuthentication.Controllers
{
    public class VoteController : Controller
    {
        // GET: Vote
        public ActionResult Up(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Post.FirstOrDefault(f => f.Id == id);
            if (post == null)
            {
                return RedirectToAction("Index", "Home");
            }
            post.UpVotes += 1;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        public ActionResult Down(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Post.FirstOrDefault(f => f.Id == id);
            if (post == null)
            {
                return RedirectToAction("Index", "Home");
            }
            post.DownVotes -= -1;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}