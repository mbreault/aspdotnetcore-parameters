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

       public static string ApplicationInsightsInstrumentationKey(IConfiguration configuration)
        {
            string returnValue = "";

            returnValue = configuration.GetSection("ApplicationInsights").GetValue<string>("InstrumentationKey");

            return returnValue;
        }
    }
}
