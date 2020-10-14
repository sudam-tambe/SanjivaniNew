using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sanjivani.Startup))]
namespace Sanjivani
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
