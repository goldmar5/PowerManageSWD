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
    public class TycoPowerManagePage : MyPageBase
    {
        #region WebElements

        [FindsBy(How = How.CssSelector, Using = @"#menuItem_units_all a")]
        protected IWebElement tabPanels { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"#menuItem_group a")]
        protected IWebElement tabGroups { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"#menuItem_event a")]
        protected IWebElement tabEvents { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"#menuItem_process a")]
        protected IWebElement tabProcesses { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"#menuItem_system a")]
        protected IWebElement tabSystem { get; set; }


        [FindsBy(How = How.CssSelector, Using = @".productVersion")]
        protected IWebElement textVersion { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"#userImploadName")]
        protected IWebElement textCurrentUser { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"#app_layout_AnimatedLink_0")]
        protected IWebElement linkSettings { get; set; }


        [FindsBy(How = How.CssSelector, Using = @"#app_layout_AnimatedLink_1")]
        protected IWebElement linkLogout { get; set; }


        [FindsBy(How = How.CssSelector, Using = @".help")]
        protected IWebElement linkHelp { get; set; }

        #endregion

        #region Invoke() and IsDisplayed()
        public override void Invoke()
        {
            SwdBrowser.Driver.Url = @"http://212.90.164.242/index/index";
        }

        public override bool IsDisplayed()
        {
            return SwdBrowser.Driver.Url.Contains(@"212.90.164");
        }
        #endregion

        public override void VerifyExpectedElementsAreDisplayed()
        {
            VerifyElementVisible("tabPanels", tabPanels);
            VerifyElementVisible("tabGroups", tabGroups);
            VerifyElementVisible("tabEvents", tabEvents);
            VerifyElementVisible("tabProcesses", tabProcesses);
            VerifyElementVisible("tabSystem", tabSystem);
            VerifyElementVisible("textVersion", textVersion);
            VerifyElementVisible("textCurrentUser", textCurrentUser);
            VerifyElementVisible("linkSettings", linkSettings);
            VerifyElementVisible("linkLogout", linkLogout);
            VerifyElementVisible("linkHelp", linkHelp);
        }
    }
}