using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEBTEST.Startup))]
namespace WEBTEST
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
