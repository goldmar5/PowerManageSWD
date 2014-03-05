using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var LoginPage = new Demo.TestModel.PageDeclarations.ipmpLoginPage();
            LoginPage.Login();
        }
    }
}
