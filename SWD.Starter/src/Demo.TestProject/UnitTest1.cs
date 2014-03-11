using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.TestModel.PageDeclarations;

namespace Demo.TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoginExample()
        {
            var LoginPage = new ipmpLoginPage();
            LoginPage.Login();
        }
    }
}
