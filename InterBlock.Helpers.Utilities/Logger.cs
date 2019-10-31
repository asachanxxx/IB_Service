using InterBlock.Helpers.Configurations;
using Interblocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterBlock.Helpers.Utilities
{
    public class Logger
    {

        //System Configuration
        ////public static string ConfigPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\SystemConfiguration.cnf");
        ////public static string SystemKeyPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\SystemConfiguration.key");
        public static string SysKey;


        //Log Configuration
        //public static string LogSysConfigPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\StatementDataServiceLogConfiguration.cnf");
        //public static string LogKeyPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Interblocks\Statement Module\Statement Data Service\Config\StatementDataServiceLogConfiguration.key");
        public static string LogKey;



        public static void LoggerInitialize()
        {
            //System Configuration
            IBKeyStore oStore = new IBKeyStore();
            SysKey = oStore.GetMasterKey(MainConfigurationPaths.SystemKeyPath);
            SystemConfiguration.Initialize(SysKey, MainConfigurationPaths.ConfigPath);

            //Log Configuration
            IBKeyStore oLogStore = new IBKeyStore();
            LogKey = oLogStore.GetMasterKey(MainConfigurationPaths.LogKeyPath);
            IBLogInstanceProperties oLogInstanceProp = new IBLogInstanceProperties(LogKey, MainConfigurationPaths.LogSysConfigPath);
            IBLogInstance log = new IBLogInstance("001", oLogInstanceProp);
            IBLogger.AddInstance(log);
            IBLogger.Initialize(oLogInstanceProp);

        }

        public static void LogHeader()
        {
            IBLogger.Write(LOG_OPTION.INFO, "");
            IBLogger.Write(LOG_OPTION.INFO, "");
            IBLogger.Write(LOG_OPTION.INFO, "------------------------------------------------------------------------");
            IBLogger.Write(LOG_OPTION.INFO, "----------------- (: Interblocks - Statement API :) ------------------");
            IBLogger.Write(LOG_OPTION.INFO, "------------------------------------------------------------------------");
            IBLogger.Write(LOG_OPTION.INFO, "Starting Application on Date : " + DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss"));
            IBLogger.Write(LOG_OPTION.INFO, "Card Schema Name       : " + SystemConfiguration.CARD_SCHEMA_NAME);
            IBLogger.Write(LOG_OPTION.INFO, "PCI Enable             : " + SystemConfiguration.PCI_ENABLE);
            IBLogger.Write(LOG_OPTION.INFO, "DB Host ServiceName    : " + SystemConfiguration.DB_HOST_SERVICE_NAME);
            IBLogger.Write(LOG_OPTION.INFO, "DB DSN                 : " + SystemConfiguration.DB_DSN);
            IBLogger.Write(LOG_OPTION.INFO, "DB DBMS                : " + SystemConfiguration.DB_DBMS);
            IBLogger.Write(LOG_OPTION.INFO, "DB File Name           : " + SystemConfiguration.DB_FILE_NAME);
            IBLogger.Write(LOG_OPTION.INFO, "DB File Path           : " + SystemConfiguration.DB_FILE_PATH);
            IBLogger.Write(LOG_OPTION.INFO, "DB Catalog Name        : " + SystemConfiguration.DB_CATALOG_NAME);
            IBLogger.Write(LOG_OPTION.INFO, "DB DataBase Name       : " + SystemConfiguration.DB_DATABASE_NAME);
            IBLogger.Write(LOG_OPTION.INFO, "DB Schema Name         : " + SystemConfiguration.DB_SCHEMA_NAME);
            IBLogger.Write(LOG_OPTION.INFO, "DB User Name           : " + SystemConfiguration.DB_USER_NAME);
            IBLogger.Write(LOG_OPTION.INFO, "DB Host IP             : " + SystemConfiguration.DB_HOST_IP);
            IBLogger.Write(LOG_OPTION.INFO, "DB Host Port           : " + SystemConfiguration.DB_HOST_PORT);
            IBLogger.Write(LOG_OPTION.INFO, "Listen IP              : " + SystemConfiguration.LISTEN_IP);
            IBLogger.Write(LOG_OPTION.INFO, "Listen Port            : " + SystemConfiguration.LISTEN_PORT);
            IBLogger.Write(LOG_OPTION.INFO, "Customer Print Staus   : " + SystemConfiguration.CUSTOMER_PRINT);
            IBLogger.Write(LOG_OPTION.INFO, "Customer RePrint Staus : " + SystemConfiguration.CUSTOMER_REPRINT);
            IBLogger.Write(LOG_OPTION.INFO, "Merchant Print Staus   : " + SystemConfiguration.MERCHANT_PRINT);
            IBLogger.Write(LOG_OPTION.INFO, "Merchant RePrint Staus : " + SystemConfiguration.MERCHANT_REPRINT);
            IBLogger.Write(LOG_OPTION.INFO, "SVC Card Print Staus   : " + SystemConfiguration.SVC_PRINT);
            IBLogger.Write(LOG_OPTION.INFO, "SVC Card RePrint Staus : " + SystemConfiguration.SVC_REPRINT);
            IBLogger.Write(LOG_OPTION.INFO, "Version (Product)      : " + SystemConfiguration.PRODUCT);
            IBLogger.Write(LOG_OPTION.INFO, "Version (OTHER)        : " + SystemConfiguration.OTHER);
            IBLogger.Write(LOG_OPTION.INFO, "");
        }

        public static void LogInfo(string _Field, string message)
        {
            IBLogger.Write(LOG_OPTION.INFO, _Field.PadRight(50, '-') + message);
        }
        public static void LogError(string _Field, string message)
        {
            IBLogger.Write(LOG_OPTION.ERROR, _Field.PadRight(50, '-') + message);
        }
        public static void LogDebug(string _Field, string message)
        {
            IBLogger.Write(LOG_OPTION.DEBUG, _Field.PadRight(50, '-') + message);
        }

        public static void LogSubHeader(string message)
        {
            var paddingone = message.PadLeft(30,'-').PadRight(70,'-');
            IBLogger.Write(LOG_OPTION.INFO, paddingone);
        }
        public static void LogEmpty()
        {
            IBLogger.Write(LOG_OPTION.INFO, "");
        }

        public static void LogSeparater()
        {
            IBLogger.Write(LOG_OPTION.INFO, "------------------------------------------------------------------------");
        }
        public static void LogSeparater(string message)
        {
            var paddingone = message.PadLeft(30, '-').PadRight(70, '-');
            IBLogger.Write(LOG_OPTION.INFO, paddingone);
        }

        public static void LogExceptionOnControllers(Exception logMetadata, string methodname)
        {
            Logger.LogEmpty();
            Logger.LogSubHeader("Exception Occured on Below Request");
            Logger.LogError("Error Text: ", logMetadata.Message);
            Logger.LogInfo("StackTrace", logMetadata.StackTrace);
            if (logMetadata.InnerException != null) {
                Logger.LogError("Inner Exception: ", logMetadata.InnerException.Message);
            }
            Logger.LogSeparater("Exception Ended");
            Logger.LogEmpty();

           
        }
    }
}
