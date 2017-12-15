using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(carshareassiststarter.Startup))]
namespace carshareassiststarter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
