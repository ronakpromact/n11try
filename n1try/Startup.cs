using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(n1try.Startup))]
namespace n1try
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
