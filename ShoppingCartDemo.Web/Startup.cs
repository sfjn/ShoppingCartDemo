using App.ShoppingCartDemo.Web;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
namespace App.ShoppingCartDemo.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();

            // Configure Web API Routes:
            // - Enable Attribute Mapping
            // - Enable Default routes at /api.
            httpConfiguration.MapHttpAttributeRoutes();
            httpConfiguration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(httpConfiguration);
            app.UseStageMarker(PipelineStage.MapHandler);
            //ShoppingCartDemo.Common.AutoMapper.Initialize();
            //WebApiConfig.Register(httpConfiguration);
        }
    }
}
