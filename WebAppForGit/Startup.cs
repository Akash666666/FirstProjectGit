using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppForGit.Startup))]
namespace WebAppForGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
