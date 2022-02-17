using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecflowProject.CommonSettings;
using SeleniumSpecflowProject.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumSpecflowProject.Steps
{
    [Binding]
    class Initialiser
    {
        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;


        //public ILoginPage LoginPage;
        //public IDashboardPage DashboardPage;
        //public IProductsPage ProductsPage;


        public Initialiser(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void Initialize()
        {
            if (LoadAppData.GetTestData("browser") != "")
            {
                Driver.Instance = null;
                Driver.Initialize();
            }

            if (Driver.Instance != null)
            {
                

            }
        }

        [AfterScenario()]
        public void CloseDriver()
        {
            try
            {
                TakeScreenshot(Driver.Instance);
                Driver.Instance.Close();
                Driver.Instance.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Driver.Instance = null;

            try
            {
                foreach (var process in Process.GetProcesses())
                {
                    if (process.ProcessName == "geckodriver")
                    {
                        process.Kill();
                    }
                    else if (process.ProcessName == "chromedriver")
                    {
                        process.Kill();
                    }
                    else if (process.ProcessName == "phantomjs")
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void TakeScreenshot(IWebDriver driver)
        {
            if (_scenarioContext.TestError != null)
            {
                var screenshotWebDriver = (ITakesScreenshot)driver;
                if (screenshotWebDriver != null)
                {
                    var path = Directory.GetCurrentDirectory();
                    var screenshotFile = $"{path}{DateTime.Now:dd.MM.yyyy-HH.mm.ss.ff}.png";
                    File.WriteAllBytes(screenshotFile, screenshotWebDriver.GetScreenshot().AsByteArray);
                    TestContext.AddTestAttachment(screenshotFile);
                    Console.WriteLine($"Path:{screenshotFile}");
                }
            }
        }


    }
}
