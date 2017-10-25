using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DSWebProject.Startup))]
namespace DSWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
