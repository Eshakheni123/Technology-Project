using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JigneshWebApplication1.Startup))]
namespace JigneshWebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
