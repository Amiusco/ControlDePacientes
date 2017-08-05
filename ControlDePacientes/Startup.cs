using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlDePacientes.Startup))]
namespace ControlDePacientes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
