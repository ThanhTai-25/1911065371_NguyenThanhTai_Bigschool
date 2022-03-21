using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911065371_NguyenThanhTai_Bigschool.Startup))]
namespace _1911065371_NguyenThanhTai_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
