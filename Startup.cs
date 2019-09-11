using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVCS_Exercise2._0.Startup))]
namespace DVCS_Exercise2._0
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
