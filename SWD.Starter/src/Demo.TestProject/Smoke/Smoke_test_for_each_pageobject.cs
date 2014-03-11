﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Demo.TestModel;
using Swd.Core.Pages;
using Demo.TestModel.PageDeclarations;
using Swd.Core.WebDriver;

namespace Demo.TestProject.Smoke
{
    [TestClass]
    public class Smoke_test_for_each_pageobject
    {

        public void PageTest<PAGE>(PAGE page) where PAGE : MyPageBase, new()
        {
            // Implement Dispose inside page object in order to do cleanup
            using (page)
            {
                page.Invoke();
                page.VerifyExpectedElementsAreDisplayed();
                SwdBrowser.CloseDriver();
            }
        }

        
        // Add testMethods for your new pages here:
        // *PageName*_VerifyExpectedElements()

        [TestMethod]
        public void LogoutMenuPage_VerifyExpectedElements()
        {
            PageTest(MyPages.LogoutMenuPage);
        }
  
        [TestMethod]
        public void TycoPowerManagePage_VerifyExpectedElements()
        {            
            PageTest(MyPages.TycoPowerManagePage);
        }        

        [TestMethod]
        public void ipmpLoginPage_VerifyExpectedElements()
        {
            PageTest(MyPages.ipmpLoginPage);
        }

        [TestMethod]
        public void UnitListPage_VerifyExpectedElements()
        {
            PageTest(MyPages.UnitListPage);
        }

        [TestMethod]
        public void GroupPage_VerifyExpectedElements()
        {
            PageTest(MyPages.GroupPage);
        }

        [TestMethod]
        public void EventsPage_VerifyExpectedElements()
        {
            PageTest(MyPages.EventsPage);
        }

        [TestMethod]
        public void ProcessesPage_VerifyExpectedElements()
        {
            PageTest(MyPages.ProcessesPage);
        }

        [TestMethod]
        public void SystemPage_VerifyExpectedElements()
        {
            PageTest(MyPages.SystemPage);
        }

        //[TestMethod]
        //public void CreateNewAccountPage_VerifyExpectedElements()
        //{
        //    PageTest(MyPages.CreateNewAccountPage);
        //}
    }
}
