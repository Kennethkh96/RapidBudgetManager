using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RapidBudgetManager.Startup))]
namespace RapidBudgetManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
