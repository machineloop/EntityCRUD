using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityCRUD.Startup))]
namespace EntityCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
