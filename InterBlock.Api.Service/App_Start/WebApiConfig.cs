﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using InterBlock.Helpers.Utilities;
using InterBlock.Helpers.Configurations;

namespace InterBlock.Api.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.MessageHandlers.Add(new CustomLogHandler());

            Logger.LoggerInitialize();
            Logger.LogHeader();
            Logger.LogInfo("Starting Application on Date", DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss"));
            
        }

        private void InitializePaths() {
            MainConfigurationPaths.MainResourcePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module");
            MainConfigurationPaths.DB2QueryJsonPath = "DB2QueryJson.json";
            MainConfigurationPaths.MSSQLQueryJsonPath = "MSSQLQueryJson.json";
            MainConfigurationPaths.MYSQLQueryJsonPath = "MYSQLQueryJson.json";
            MainConfigurationPaths.PSQLQueryJsonPath = "PSQLQueryJson.json";
        }
    }
}
