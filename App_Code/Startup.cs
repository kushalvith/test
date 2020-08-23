using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.net.Startup))]
namespace asp.net
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
