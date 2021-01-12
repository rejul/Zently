using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zently.Startup))]
namespace Zently
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
