using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LapTimes.Server.Api.Startup))]

namespace LapTimes.Server.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
