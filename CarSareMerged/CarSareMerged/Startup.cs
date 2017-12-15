using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarSareMerged.Startup))]
namespace CarSareMerged
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
