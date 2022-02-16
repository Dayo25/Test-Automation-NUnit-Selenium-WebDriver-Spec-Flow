using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject
{
    class TestCaseLogIn
    {
        [Test]
        public void WebDriverTest()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://admin-demo.nopcommerce.com/login");
            
            webDriver.FindElement(By.Id("Email")).Clear();
            webDriver.FindElement(By.Id("Email")).SendKeys("admin@yourstore.com");
            
            webDriver.FindElement(By.Id("Password")).Clear();
            webDriver.FindElement(By.Id("Password")).SendKeys("admin");
            webDriver.FindElement(By.ClassName("buttons")).Click();
        }
    }
}
