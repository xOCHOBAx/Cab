using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetCab.WebUISecond.Startup))]
namespace GetCab.WebUISecond
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
