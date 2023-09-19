using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Remind.Startup))]
namespace Remind
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
