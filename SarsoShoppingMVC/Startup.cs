using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SarsoShoppingMVC.Startup))]
namespace SarsoShoppingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
