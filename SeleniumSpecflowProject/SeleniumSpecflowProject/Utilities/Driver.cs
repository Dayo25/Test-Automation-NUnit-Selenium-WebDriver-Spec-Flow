using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSpecflowProject.CommonSettings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SeleniumSpecflowProject.Utilities
{
    class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get
            {
                return LoadAppData.GetBaseWebUrl();
            }
        }

        public static void Initialize()
        {
            var browser = LoadAppData.GetTestData("browser");
            switch (browser)
            {
                case "firefox":
                    //Code goes here
                    break;
                case "chrome":

                    ChromeOptions chOptions = new ChromeOptions
                    {
                        AcceptInsecureCertificates = true
                    };
                    if (LoadAppData.GetTestData("headless") == "true")
                    {
                        chOptions.AddArguments("headless");
                    }
                    {
                        var service = ChromeDriverService.CreateDefaultService(@GetDriverPath());
                        Instance = new ChromeDriver(service, chOptions, TimeSpan.FromSeconds(120));
                        Instance.Manage().Window.Maximize();
                    }
                    break;
            }

            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }


        public static void Close()
        {
            Instance.Close();
        }


        private static string GetDriverPath()
        {

            var requiredPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(requiredPath);
            return requiredPath;
        }




    }
}

