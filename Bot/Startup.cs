using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bot.Startup))]
namespace Bot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
