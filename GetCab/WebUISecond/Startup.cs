using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebUISecond.Startup))]
namespace WebUISecond
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
