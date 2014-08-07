using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtGallery.Web.Startup))]
namespace ArtGallery.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
