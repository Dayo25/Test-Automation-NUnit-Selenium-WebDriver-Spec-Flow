using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject.Interfaces
{
   public interface IDashBoardPage: IBasePage
    {
        void ClickOnCatalogButton();
        void ClickOnProductButton();
    }
}
