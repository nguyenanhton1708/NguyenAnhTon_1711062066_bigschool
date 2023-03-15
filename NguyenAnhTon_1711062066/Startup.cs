using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenAnhTon_1711062066.Startup))]
namespace NguyenAnhTon_1711062066
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
