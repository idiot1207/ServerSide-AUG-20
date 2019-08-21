using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TFS.Startup))]
namespace TFS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
