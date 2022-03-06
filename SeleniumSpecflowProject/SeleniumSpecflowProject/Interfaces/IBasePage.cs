using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject.Interfaces
{
    public interface IBasePage
    {
        public interface IBasePage 
        {
            void EnterText(IWebElement inputElement, string textValue);
            void SelectTextFromValueListDropDown(IWebElement element, string text);
            void SelectFromValueListDropDown(IWebElement element, string value);

            void NavigateToBaseUrl();


        }
    }
}
