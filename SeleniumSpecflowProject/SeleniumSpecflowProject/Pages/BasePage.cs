using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSpecflowProject.CommonSettings;
using SeleniumSpecflowProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumSpecflowProject.Pages
{
   
    
        public abstract class BasePage : IBasePage
        {
            protected IWebDriver Driver;
            protected BasePage(IWebDriver driver)
            {
                Driver = driver;
            }

            public void EnterText(IWebElement inputElement, string textValue)
            {
                inputElement.Clear();
                inputElement.SendKeys(textValue);
            }

            public void SelectTextFromValueListDropDown(IWebElement element, string text)
            {
                SelectElement select = new SelectElement(element);
                select.SelectByText(text);
            }

            public void SelectFromValueListDropDown(IWebElement element, string value)
            {
                SelectElement select = new SelectElement(element);
                select.SelectByValue(value);
            }
            public List<string> GetListOfValuesFromWebElement(IList<IWebElement> elements)
            {
                List<string> x = new List<string>();
                foreach (IWebElement element in elements)
                {
                    x.Add(element.Text);
                }
                return x;

            }
            public void NavigateToBaseUrl()
            {
                var baseUrl = LoadAppData.GetBaseWebUrl();
                Driver.Navigate().GoToUrl(baseUrl);
                Thread.Sleep(1000);
                //WaitForPageLoad();
            }

        }
    }
