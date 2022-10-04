using System;
using OpenQA.Selenium;

namespace AuthorizationCianPageTests.PageObjects
{
    public class AuthorizationPageObject
    {
        private IWebDriver webDriver;

        private readonly By _email = By.XPath("//input[@name='email']");
        private readonly By _password = By.XPath("//input[@name='password']");
        private readonly By _enterButton = By.XPath("//button[@type='submit']");

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public MainMenuPageObject Login(string login, string password)
        {
            webDriver.FindElement(_email).SendKeys(login);
            webDriver.FindElement(_password).SendKeys(password);
            webDriver.FindElement(_enterButton).Click();
            return new MainMenuPageObject(webDriver);
        }
    }
}
