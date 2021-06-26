using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_thuc_hanh.Startup))]
namespace lab3_thuc_hanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
