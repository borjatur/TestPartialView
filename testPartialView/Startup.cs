using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testPartialView.Startup))]
namespace testPartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
