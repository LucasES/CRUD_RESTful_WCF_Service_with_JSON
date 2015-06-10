using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrudWithJsonClient.Startup))]
namespace CrudWithJsonClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
