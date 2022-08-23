using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HadithSearch.Startup))]
namespace HadithSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
