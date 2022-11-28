using GTI.CADASTRO.API.Services;
using GTI.CADASTRO.API.Services.Interface;
using GTI.CADASTRO.REPOSITORY.Repositories;
using GTI.CADASTRO.REPOSITORY.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace GTI.CADASTRO.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //repository
            container.RegisterType<IClienteRepository, ClienteRepository>(new HierarchicalLifetimeManager());

            //services
            container.RegisterType<IClienteService, ClienteService>(new HierarchicalLifetimeManager());


            config.DependencyResolver = new UnityDependencyResolver(container);

        }
    }
}
