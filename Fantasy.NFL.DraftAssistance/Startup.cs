using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fantasy.NFL.DraftAssistance.Startup))]
namespace Fantasy.NFL.DraftAssistance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
