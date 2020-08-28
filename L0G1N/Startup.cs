using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L0G1N.Startup))]
namespace L0G1N
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
