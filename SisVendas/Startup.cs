using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SisVendas.Startup))]
namespace SisVendas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
