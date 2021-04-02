using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCUHealthcareViewsTest.Startup))]
namespace GCUHealthcareViewsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
