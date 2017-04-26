using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditCloneAndAuthentication.Models;
using Microsoft.AspNet.Identity;

namespace RedditCloneAndAuthentication.Controllers
{
    public class VoteController : Controller
    {
        // GET: Vote
        public ActionResult Up(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Post.FirstOrDefault(f => f.Id == id);
            post.UpVotes += 1;
            db.SaveChanges();
            ViewBag.UserId = User.Identity.GetUserId();
            return PartialView("_voteDisplay", post);
        }


        public ActionResult Down(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.Post.FirstOrDefault(f => f.Id == id);
            post.DownVotes += 1;
            db.SaveChanges();
            ViewBag.UserId = User.Identity.GetUserId();
            return PartialView("_voteDisplay", post);
        }
    }
}