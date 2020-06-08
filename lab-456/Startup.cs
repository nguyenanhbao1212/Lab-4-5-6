using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_456.Startup))]
namespace lab_456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
