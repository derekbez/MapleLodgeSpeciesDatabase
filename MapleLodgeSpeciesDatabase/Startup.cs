using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapleLodgeSpeciesDatabase.Startup))]
namespace MapleLodgeSpeciesDatabase
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
