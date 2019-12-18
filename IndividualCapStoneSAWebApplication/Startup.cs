using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndividualCapStoneSAWebApplication.Startup))]
namespace IndividualCapStoneSAWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
