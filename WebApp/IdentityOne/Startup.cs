using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityOne.Startup))]
namespace IdentityOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
