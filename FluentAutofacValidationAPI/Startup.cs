using Owin;

namespace FluentAutofacValidationAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = ConfigureAutofac();
            ConfigureWebApi(app, container);
        }
    }
}