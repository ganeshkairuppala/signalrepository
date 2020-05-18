using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication32.Startup))]
namespace WebApplication32
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
