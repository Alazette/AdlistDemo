using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreggsList.Startup))]
namespace GreggsList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
