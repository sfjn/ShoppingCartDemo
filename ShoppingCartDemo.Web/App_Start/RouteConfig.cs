// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2017 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using App.Web1.Routing;
using System.Web.Routing;

namespace App.ShoppingCartDemo.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
