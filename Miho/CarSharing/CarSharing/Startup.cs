using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarSharing.Startup))]
namespace CarSharing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
