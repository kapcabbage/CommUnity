using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommUnity.Startup))]
namespace CommUnity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
