// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright � 2017
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.ShoppingCartDemo.Web.Client
{
    using App.ShoppingCartDemo.Web.Client.Routing;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Default", new DefaultRoute());
        }
    }
}