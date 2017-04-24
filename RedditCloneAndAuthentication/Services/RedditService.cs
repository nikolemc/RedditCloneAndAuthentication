using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using RedditCloneAndAuthentication.Models;

namespace RedditCloneAndAuthentication.Services
{
    public class RedditService
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Post> GetAllPosts()
        {
            return db.Post;
        }
    }
}