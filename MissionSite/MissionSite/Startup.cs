using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestOAuth.Startup))]
namespace TestOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
