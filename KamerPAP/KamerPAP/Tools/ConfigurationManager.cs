using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tools
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigurationManager
    {
        /// <summary>
        /// The application settings
        /// </summary>
        private static IConfigurationSection _appSettings = null;

        /// <summary>
        /// Return a value key from section AppSettings of appsettings.json
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static string GetAppSettings(string key)
        {
            if (_appSettings == null)
            {
                IConfigurationBuilder configBuilder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables();
                IConfiguration config = configBuilder.Build();

                _appSettings = config.GetSection("AppSettings");
            }
            return _appSettings[key];
        }
    }
}
