using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleAPP.Startup))]
namespace SampleAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
