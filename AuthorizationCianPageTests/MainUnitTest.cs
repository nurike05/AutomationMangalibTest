using AuthorizationCianPageTests.PageObjects;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace AuthorizationCianPageTests
{
    public class Tests
    {
        //private IWebDriver driver;
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
                //var expectedResult = UserNameForTests.GetUserName();
                var expectedResult = UserNameForTests.userLogin;

                // act
                //var actualResult = steps.CheckUserName();
                var actualResult = steps.CheckUserName();

                // assert
                Assert.AreEqual(expectedResult, actualResult);
         
       
        }

        [Test, TestCaseSource("Testing.xml")]
        [Category("Testing")]
        [Ignore("")]
        public void MainTestWithXML()
        {
            
                // arrange
                steps.LoginMangalib();
                //var expectedResult = UserNameForTests.GetUserName();
                var expectedResult = UserNameForTests.userLogin;

                // act
                //var actualResult = steps.CheckUserName();
                var actualResult = steps.CheckUserName();

                // assert
                Assert.AreEqual(expectedResult, actualResult);
       
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
