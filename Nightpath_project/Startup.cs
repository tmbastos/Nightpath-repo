using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nightpath_project.Startup))]
namespace Nightpath_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
