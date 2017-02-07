using App.ShoppingCartDemo.Web;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
namespace App.ShoppingCartDemo.Web
{
    //using Microsoft.Owin.FileSystems;
    //using Microsoft.Owin.StaticFiles;

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

            // Make ./public the default root of the static files in our Web Application.
            //       app.UseFileServer(new FileServerOptions
            //        {
            //             RequestPath = new PathString(string.Empty),
            //              FileSystem = new PhysicalFileSystem("./public"),
            //               EnableDirectoryBrowsing = true,
            //            });

            app.UseStageMarker(PipelineStage.MapHandler);

            //WebApiConfig.Register(httpConfiguration);

            //ShoppingCartDemo.Common.AutoMapper.Initialize();
        }
    }
}
