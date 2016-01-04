using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobsAPI.Startup))]
namespace JobsAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
