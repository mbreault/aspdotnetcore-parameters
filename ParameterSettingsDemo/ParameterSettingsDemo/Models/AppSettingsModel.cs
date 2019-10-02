using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParameterSettingsDemo.Models
{
    public class AppSettingsModel
    {
        public string AllowedHosts { get; set; }
        public LoggingModel Logging { get; set; }
    }
}
