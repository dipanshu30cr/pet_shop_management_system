using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pet_shop_management_system.Startup))]
namespace pet_shop_management_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
