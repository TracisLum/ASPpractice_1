using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPpractice_1.Startup))]
namespace ASPpractice_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
