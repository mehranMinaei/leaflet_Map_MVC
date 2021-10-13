using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(useleaflet_Map.Startup))]
namespace useleaflet_Map
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
