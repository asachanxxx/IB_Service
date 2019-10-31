using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using InterBlock.Helpers.Utilities;
using InterBlock.Helpers.Configurations;
using System.IO;

[assembly: OwinStartup(typeof(InterBlock.Api.Service.Startup))]

namespace InterBlock.Api.Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            ConfigureStartups.RegisterStartupParams();
        }
    }

    public class ConfigureStartups{

        public static void RegisterStartupParams() {

            InitializePaths();
            Logger.LoggerInitialize();
            Logger.LogHeader();
            Logger.LogInfo("Starting Application on Date", DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss"));

           
        }

        private static void InitializePaths()
        {
            MainConfigurationPaths.MainResourcePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module");
            MainConfigurationPaths.DB2QueryJsonPath = Path.Combine( MainConfigurationPaths.MainResourcePath , Path.Combine("SQLQueryJsons", "DB2QueryJson.json"));
            MainConfigurationPaths.MSSQLQueryJsonPath = Path.Combine(MainConfigurationPaths.MainResourcePath, Path.Combine("SQLQueryJsons", "MSSQLQueryJson.json")); 
            MainConfigurationPaths.MYSQLQueryJsonPath = Path.Combine(MainConfigurationPaths.MainResourcePath, Path.Combine("SQLQueryJsons", "MYSQLQueryJson.json")); 
            MainConfigurationPaths.PSQLQueryJsonPath = Path.Combine(MainConfigurationPaths.MainResourcePath, Path.Combine("SQLQueryJsons", "PSQLQueryJson.json")); 

            MainConfigurationPaths.ConfigPath  = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\SystemConfiguration.cnf");
            MainConfigurationPaths.SystemKeyPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\SystemConfiguration.key");

            MainConfigurationPaths.LogSysConfigPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\StatementDataServiceLogConfiguration.cnf");
            MainConfigurationPaths.LogKeyPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\StatementDataServiceLogConfiguration.key");


        }
    }


}
