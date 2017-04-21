using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedditCloneAndAuthentication.Startup))]
namespace RedditCloneAndAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
