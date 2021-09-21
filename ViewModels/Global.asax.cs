using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ViewModels
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Controllers.HundController.FellListe.Add(
                new Models.Fell()
                {
                    Id = ViewModels.Controllers.HundController.FellListe.Count() + 1,
                    Farbe = Models.FarbeEnum.schwarz

                }); ;

                Controllers.HundController.FellListe.Add(
                new Models.Fell() 
                {
                    Id = ViewModels.Controllers.HundController.FellListe.Count() + 1,
                    Farbe = Models.FarbeEnum.orange 

                });

                 Controllers.HundController.FellListe.Add(
                new Models.Fell() 
                {
                    Id = ViewModels.Controllers.HundController.FellListe.Count() + 1,
                    Farbe = Models.FarbeEnum.braun 

                });

                 Controllers.HundController.FellListe.Add(
                new Models.Fell()
                {
                    Id = ViewModels.Controllers.HundController.FellListe.Count() + 1,
                    Farbe = Models.FarbeEnum.andere 

                });

            Controllers.HundController.HundeListe.Add(
                new Models.Hund
                { 
                    Id = 1,
                    Active = true,
                    Age = 22,
                    Beine = 3.5,
                    FellId = 1,
                    Name = "Wuffi" 
                });

            Controllers.HundController.HundeListe.Add(
                new Models.Hund
                { 
                    Id = 2,
                    Active = true,
                    Age = 11,
                    Beine = 4,
                    FellId = 2,
                    Name = "Bello" 
                });

            Controllers.HundController.HundeListe.Add(
                new Models.Hund
                { 
                    Id = 3,
                    Active = true,
                    Age = 14,
                    Beine = 3,
                    FellId = 3,
                    Name = "Oli" 
                });
               
        }
    }
}
