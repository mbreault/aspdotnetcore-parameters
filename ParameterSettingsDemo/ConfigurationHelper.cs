using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParameterSettingsDemo
{
    public static class ConfigurationHelper
    {
       public static string GetEnvVar(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }

       public static string GetTestSetting(IConfiguration configuration)
        {
            string returnValue = "";

            returnValue = GetEnvVar("ApplicationInsights_InstrumentationKey");

            if (String.IsNullOrEmpty(returnValue))
            {
                returnValue = configuration.GetValue<string>("ApplicationInsights_InstrumentationKey");
            }

            return returnValue;
        }
    }
}
