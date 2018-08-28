using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using IoC_practice.Logger;
using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Owin;

[assembly: OwinStartupAttribute(typeof(IoC_practice.Startup))]
namespace IoC_practice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<MyLogger>().As<IMyLogger>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            ConfigureAuth(app);
        }
    }
}
