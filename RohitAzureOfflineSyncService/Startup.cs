using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RohitAzureOfflineSyncService.Startup))]

namespace RohitAzureOfflineSyncService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}