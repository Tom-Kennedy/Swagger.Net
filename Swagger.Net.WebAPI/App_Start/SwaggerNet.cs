﻿using System;
using System.IO;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Dispatcher;
using System.Web.Routing;
using Swagger.Net;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Swagger.Net.WebApi.App_Start.SwaggerNet), "PreStart")]
[assembly: WebActivator.PostApplicationStartMethod(typeof(Swagger.Net.WebApi.App_Start.SwaggerNet), "PostStart")]
namespace Swagger.Net.WebApi.App_Start
{
    public static class SwaggerNet
    {
        public static void PreStart()
        {
            RouteTable.Routes.MapHttpRoute(
            name: Constants.Swagger,
            routeTemplate: "api/docs/{action}/{controllerName}",
            defaults: new { controller = Constants.Swagger, action = "get", controllerName = RouteParameter.Optional }
);
        }

        public static void PostStart()
        {
            var config = GlobalConfiguration.Configuration;

            try
            {
                config.Services.Replace(typeof(IDocumentationProvider),
                    new XmlCommentDocumentationProvider(HttpContext.Current.Server.MapPath("~/bin/Swagger.Net.WebApi.XML")));
            }
            catch (FileNotFoundException)
            {
                throw new Exception("Please enable \"XML documentation file\" in project properties with default (bin\\Swagger.Net.WebApi.XML) value or edit value in App_Start\\SwaggerNet.cs");
            }
        }
    }
}