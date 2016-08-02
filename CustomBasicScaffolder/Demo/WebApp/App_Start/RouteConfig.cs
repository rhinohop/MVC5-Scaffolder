using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using UnitySample;

namespace WebApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("WcfDataService1.svc/{*pathInfo}");
            //routes.Add(new ServiceRoute("DataSourceService", new DataServiceHostFactory(), typeof(WcfDataService1)));
            //RouteTable.Routes.Add(new ServiceRoute("SVC/My", new WcfServiceFactory(), typeof(WebApp.WCF.BASE_CIQCODE)));
            
            //routes.IgnoreRoute("{file}.html");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


           



            
        }
    }
}
