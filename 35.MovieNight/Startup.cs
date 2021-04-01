using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_35.MovieNight.Startup))]
namespace _35.MovieNight
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
