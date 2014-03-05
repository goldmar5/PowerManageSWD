#region Usings - System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion
#region Usings - SWD
using Swd.Core;
using Swd.Core.Pages;
using Swd.Core.WebDriver;
#endregion
#region Usings - WebDriver
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
#endregion
namespace Demo.TestModel.PageDeclarations
{
    public class LogoutMenuPage : MyPageBase
    {
        #region WebElements        

        [FindsBy(How = How.CssSelector, Using = @"#logout_alink")]
        protected IWebElement linkFullLogout { get; set; }

        [FindsBy(How = How.CssSelector, Using = @".caption")]
        protected IWebElement labelCaption { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#mainModalDialog")]
        protected IWebElement mainModalDialog { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            var LoginPage = new ipmpLoginPage();
            var tycoPage = LoginPage.Login();
            tycoPage.WaitLoadPage();
            var LogoutPage = tycoPage.Logout();
            LogoutPage.WaitLoadPage();
        }

        public override bool IsDisplayed()
        {
            return SwdBrowser.Driver.PageSource.Contains(@"class='caption'>Logout Menu");
        }
        #endregion

        public override void VerifyExpectedElementsAreDisplayed()
        {
            VerifyElementVisible("linkFullLogout", linkFullLogout);
            VerifyElementVisible("labelCaption", labelCaption);
        }

        public void WaitLoadPage()
        {
            Wait.UntilVisible(labelCaption, 10000);
            Wait.UntilDisapear(mainModalDialog, 15000);
        }

        public void Logout()
        {
            linkFullLogout.Click();
        }
    }
}