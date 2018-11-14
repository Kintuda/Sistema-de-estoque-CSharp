using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(enzo_estoque.Startup))]
namespace enzo_estoque
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
