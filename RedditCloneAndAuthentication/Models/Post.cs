using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditCloneAndAuthentication.Models
{
    public class Post
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public DateTime PostedTimeStamp { get; set; }
        public string PostImg { get; set; }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}