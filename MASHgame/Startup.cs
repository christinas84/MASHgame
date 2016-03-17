using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MASHgame.Startup))]
namespace MASHgame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
