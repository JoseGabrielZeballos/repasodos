using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRp2s.Startup))]
namespace WebRp2s
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
