using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AuthorizationCianPageTests.PageObjects
{
    public class MainMenuPageObject : AbstractPage
    {
        private IWebDriver webDriver;

        private const string BASE_URL = "https://mangalib.me/";
        private readonly By _signInButton = By.XPath("//a[text()='Вход']");
        private readonly By _userProfile = By.CssSelector("a.menu__item");
        private readonly By _onImage = By.CssSelector("img.header-right-menu__avatar");
        private readonly By _userName = By.CssSelector("span.mr-10");

        public MainMenuPageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public AuthorizationPageObject SignIn()
        {
            webDriver.FindElement(_signInButton).Click();
            return new AuthorizationPageObject(webDriver);
        }

        public string CheckUserProfile()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_onImage));
            webDriver.FindElement(_onImage).Click();
            webDriver.FindElement(_userProfile).Click();
            string result = webDriver.FindElement(_userName).Text;
            return result;
        }

        public override void OpenPage()
        {
            webDriver.Navigate().GoToUrl(BASE_URL);
        }
    }
}
