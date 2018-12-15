using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleAPI.Startup))]
namespace SampleAPI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
