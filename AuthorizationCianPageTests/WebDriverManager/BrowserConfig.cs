using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace AuthorizationCianPageTests.WebDriverManager
{
    public class BrowserConfig
    {
        public static string GetProjectConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static BrowserType ReadBrowserTypeFromBrowserConfig()
        {
            switch (GetProjectConfig("Browser"))
            {
                case "IE":
                    return BrowserType.IEXPLORER;
                    break;
                default:
                    return BrowserType.CHROME;
                    break;
            }
        }
    }
}
