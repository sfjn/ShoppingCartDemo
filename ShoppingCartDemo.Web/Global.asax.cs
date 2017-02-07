// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="">
//   Copyright © 2017 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using App.ShoppingCartDemo.Web;

namespace App.Web1
{
    using System.Web;
    using System.Web.Optimization;
    using System.Web.Routing;

    public class Application : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {

        }
    }
}
