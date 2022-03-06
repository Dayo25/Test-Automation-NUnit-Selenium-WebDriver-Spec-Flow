using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSpecflowProject.Interfaces
{
    public interface ILoginPage : IBasePage
    {
        void EnterEmail(string emailAddress);
        void EnterPassword(string Password);
        void ClickLoginButton();
    }
}
