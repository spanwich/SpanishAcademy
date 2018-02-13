using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpanishAcademy.Startup))]
namespace SpanishAcademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
