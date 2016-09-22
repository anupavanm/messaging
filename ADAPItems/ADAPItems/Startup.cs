using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADAPItems.Startup))]
namespace ADAPItems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
