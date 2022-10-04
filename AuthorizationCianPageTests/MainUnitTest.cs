using AuthorizationCianPageTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AuthorizationCianPageTests
{
    public class Tests
    {
        private IWebDriver driver;
        
       
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://mangalib.me/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void MainTest()
        {
            // arrange
            var mainMenu = new MainMenuPageObject(driver);
            var expectedResult = UserNameForTests.userLogin;
            mainMenu
                .SignIn()
                .Login(UserNameForTests.userLogin, UserNameForTests.userPassword);

            // act
            var actualResult = mainMenu.CheckUserProfile();
            
            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
