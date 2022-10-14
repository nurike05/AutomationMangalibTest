using AuthorizationCianPageTests.PageObjects;
using AuthorizationCianPageTests.Service;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AuthorizationCianPageTests
{
    [TestFixture]
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();
        TestListener listener = new TestListener();

        [SetUp]
        public void Setup()
        {
            steps.InitBrowser();
        }

      
        [Test]
        public void MainTest()
        {

            // arrange
            steps.LoginMangalib();
            var expectedResult = UserCreator.USER_NAME;

            // act
            var actualResult = steps.CheckUserName();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void MainTestViaXml()
        {

            // arrange
            steps.LoginMangalibViaXml();
            var expectedResult = UserCreator.USER_NAME;

            // act
            var actualResult = steps.CheckUserName();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, TestCaseSource(nameof(TestData))]
        public void MainTestWithXML(string login, string password)
        {
            // arrange
            steps.LoginMangalib(login, password);
            var expectedResult = UserCreator.USER_NAME;

            // act
            var actualResult = steps.CheckUserName();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

         private static IEnumerable TestData()
        {
            // read data from xml file
            var doc = XDocument.Load(@"C:\Users\Nurlan_Nurdildauly\source\repos\AutomationMangalibGit\testing.xml");
            return
                from vars in doc.Descendants("vars")
                let login = vars.Attribute("login").Value
                let password = vars.Attribute("password").Value
                select new object[] { login, password };
        }

        [TearDown]
        public void TearDown()
        {
            if (!TestContext.CurrentContext.Result.Outcome.Status.Equals(TestStatus.Passed))
            {
                listener.TakeScreenshot();
            }
            steps.CloseBrowser();
        }
       
    }
}
