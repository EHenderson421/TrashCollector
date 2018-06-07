using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewTrashCollector.Startup))]
namespace NewTrashCollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
