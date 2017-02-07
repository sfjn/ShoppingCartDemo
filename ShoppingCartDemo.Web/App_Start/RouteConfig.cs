// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2017 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.ShoppingCartDemo.Web
{
    using System.Web.Routing;

    using App.ShoppingCartDemo.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
