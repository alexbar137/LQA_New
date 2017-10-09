using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LQA_New.Startup))]
namespace LQA_New
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
