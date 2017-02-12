using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TESTWEBAPP.Startup))]
namespace TESTWEBAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
