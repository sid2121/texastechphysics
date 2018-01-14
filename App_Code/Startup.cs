using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(texastechphysics.Startup))]
namespace texastechphysics
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
