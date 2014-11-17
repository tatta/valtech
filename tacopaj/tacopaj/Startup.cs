using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tacopaj.Startup))]
namespace tacopaj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
