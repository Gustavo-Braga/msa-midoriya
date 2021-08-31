﻿using Microsoft.Extensions.Configuration;
using System.IO;

namespace Msa.Employee.CrossCutting
{
    public static class AppSettings
    {
        private static IConfigurationRoot _content = null;
        public static IConfigurationRoot Settings
        {
            get
            {
                if (_content == null)
                {
                    _content = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .AddEnvironmentVariables()
                            .Build();
                }
                return _content;
            }
            private set { }
        }


        public static string GetValue(string value)
        {
            var seection = Settings.GetSection(value);
            return seection.Value;
        }
    }
}
