using OpenQA.Selenium;
using SeleniumSpecflowProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject.Pages
{
    public class LoginPage : BasePage, ILoginPage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement EmailElement => Driver.FindElement(By.Id("Email"));
        private IWebElement PasswordElement => Driver.FindElement(By.Id("Password"));
        private IWebElement LoginButtonElement => Driver.FindElement(By.XPath("//button[@type='submit']"));

        public void EnterEmail(string emailAddress)
        {
            EnterText(EmailElement, emailAddress);
        }

        public void EnterPassword(string Password)
        {
            EnterText(PasswordElement, Password);
        }
        public void ClickLoginButton()
        {
            LoginButtonElement.Click();
        }

        
    }
}
