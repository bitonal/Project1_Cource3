using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project1_Cource3.Startup))]
namespace Project1_Cource3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
