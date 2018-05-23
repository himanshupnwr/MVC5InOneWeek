using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5InOneWeek.Startup))]
namespace MVC5InOneWeek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
