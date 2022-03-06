using OpenQA.Selenium;
using SeleniumSpecflowProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject.Pages
{
   public class DashBoardPage: BasePage, IDashBoardPage
    {
        public DashBoardPage(IWebDriver driver): base(driver)
        { }
        private IList<IWebElement> CatalogElement => Driver.FindElements(By.XPath("//p[contains(text(),'Catalog')]"));
        private IList<IWebElement> ProductElement => Driver.FindElements(By.XPath("//p[contains(text(),'Products')]"));


        public void ClickOnCatalogButton()
        {
            CatalogElement[0].Click();
        }
        public void ClickOnProductButton()
        {
            ProductElement[0].Click();
        }


    }
}
