using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VstsBasicApp.Startup))]
namespace VstsBasicApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
