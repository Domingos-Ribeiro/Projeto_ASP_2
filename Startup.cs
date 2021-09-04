using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projeto_ASP.Startup))]
namespace Projeto_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
