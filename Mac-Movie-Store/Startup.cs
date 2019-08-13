using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mac_Movie_Store.Startup))]
namespace Mac_Movie_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
