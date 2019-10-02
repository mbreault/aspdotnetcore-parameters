using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ParameterSettingsDemo.Models;
using System.Diagnostics;

namespace ParameterSettingsDemo.Controllers
{
    public class HomeController : Controller
    {
        /*
        private readonly IOptions<AppSettingsModel> config;

        public HomeController(IOptions<AppSettingsModel> config)
        {
            this.config = config;
        }
        */

        private IConfiguration config;

        public HomeController(IConfiguration configuration)
        {
            config = configuration;
        }

        public IActionResult Index()
        {
            //string defaultLogLevel = config.Value.Logging.LogLevel.Default;
            //string allowedHosts = config.Value.AllowedHosts;

            string defaultLogLevel = ConfigurationAbstraction.GetDefaultLogLevel(config);
            string allowedHosts = config.GetValue<string>("AllowedHosts");

            return View(new IndexViewModel { LoggingLevel = defaultLogLevel, AllowedHosts = allowedHosts });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
