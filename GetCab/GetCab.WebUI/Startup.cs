using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetCab.WebUI.Startup))]
namespace GetCab.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
