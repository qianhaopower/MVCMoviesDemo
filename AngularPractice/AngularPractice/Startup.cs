using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularPractice.Startup))]
namespace AngularPractice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
