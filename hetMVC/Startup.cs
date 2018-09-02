using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hetMVC.Startup))]
namespace hetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
