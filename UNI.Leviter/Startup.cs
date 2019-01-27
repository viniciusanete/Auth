using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using UNI.Leviter.Services;

[assembly: OwinStartup(typeof(UNI.Leviter.Startup))]

namespace UNI.Leviter
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            //CONFIGURAÇÃO DE JSON
            //config.Formatters.JsonFormatter.SerializerSettings = Settings.SerializerSettings();

            config.MapHttpAttributeRoutes();
            //config.Routes.MapHttpRoute(
            //      name: "DefaultApi",
            //      routeTemplate: "api/{controller}/{id}",
            //      defaults: new { id = RouteParameter.Optional }
            // );

            Token(app);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        private void Token(IAppBuilder app)
        {
            var opcoesConfiguracaoToken = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                Provider = new ProviderOAuth()
            };
            app.UseOAuthAuthorizationServer(opcoesConfiguracaoToken);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}
