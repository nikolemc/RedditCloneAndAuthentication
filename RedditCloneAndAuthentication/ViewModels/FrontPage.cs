using RedditCloneAndAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditCloneAndAuthentication.ViewModels
{
    public class FrontPage
    {
      
       public IEnumerable<Post> Posts { get; set; }

        
    }
}
