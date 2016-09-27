using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Print4.Startup))]
namespace Print4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
