using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IoC_practice.Startup))]
namespace IoC_practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
