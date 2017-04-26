using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditCloneAndAuthentication.Models
{
    public class PostValue
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int VoteValue { get; set; }

    }
}