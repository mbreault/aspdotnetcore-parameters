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
            string testSetting = ConfigurationHelper.GetTestSetting(config);

            return View(new IndexViewModel { TestSetting = testSetting});
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
