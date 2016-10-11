using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubBranches.Startup))]
namespace GithubBranches
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
