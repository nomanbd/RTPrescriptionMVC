using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RTPrescriptionMVC.Startup))]
namespace RTPrescriptionMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
