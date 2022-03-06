using OpenQA.Selenium;
using SeleniumSpecflowProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject.Pages
{
   public class ProductsPage: BasePage, IProductsPage
    {
        public ProductsPage(IWebDriver driver): base(driver)
        {

        }
    }
}
