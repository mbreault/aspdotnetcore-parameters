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

            returnValue = GetEnvVar("TEST_SETTING");

            if (String.IsNullOrEmpty(returnValue))
            {
                returnValue = configuration.GetValue<string>("TestSetting");
            }

            return returnValue;
        }
    }
}
