using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoCompleteWithDropDownList.Startup))]
namespace AutoCompleteWithDropDownList
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
