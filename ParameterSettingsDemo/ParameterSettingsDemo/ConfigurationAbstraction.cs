using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParameterSettingsDemo
{
    public static class ConfigurationAbstraction
    {
       public static string GetEnvVar(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }

       public static string GetDefaultLogLevel(IConfiguration configuration)
        {
            string returnValue = "";

            returnValue = GetEnvVar("LOGGING_LOGLEVEL_DEFAULT");

            if (String.IsNullOrEmpty(returnValue))
            {
                returnValue = configuration.GetSection("Logging").GetSection("LogLevel").GetValue<string>("Default");
            }

            return returnValue;
        }
    }
}
