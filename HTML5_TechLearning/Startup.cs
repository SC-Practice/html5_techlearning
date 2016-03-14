using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTML5_TechLearning.Startup))]
namespace HTML5_TechLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
