using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCarERide.Startup))]
namespace SimpleCarERide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
