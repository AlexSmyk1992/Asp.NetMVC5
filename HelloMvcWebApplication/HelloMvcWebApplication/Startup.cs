using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloMvcWebApplication.Startup))]
namespace HelloMvcWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
