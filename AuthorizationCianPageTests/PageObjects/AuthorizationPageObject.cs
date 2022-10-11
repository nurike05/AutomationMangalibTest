using System;
using AuthorizationCianPageTests.Model;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace AuthorizationCianPageTests.PageObjects
{
    public class AuthorizationPageObject
    {
        private IWebDriver webDriver;

        private readonly By _emailLocator = By.XPath("//input[@name='email']");
        private readonly By _password = By.XPath("//input[@name='password']");
        private readonly By _enterButton = By.XPath("//button[@type='submit']");

        public AuthorizationPageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public MainMenuPageObject Login(string username, string password)
        {
            webDriver.FindElement(_emailLocator).SendKeys(username);
            webDriver.FindElement(_password).SendKeys(password);
            webDriver.FindElement(_enterButton).Click();
     
            return new MainMenuPageObject(webDriver);
        }

        public MainMenuPageObject Login(User user)
        {
            webDriver.FindElement(_emailLocator).SendKeys(user.GetUsername());
            webDriver.FindElement(_password).SendKeys(user.GetPassword());
            webDriver.FindElement(_enterButton).Click();

            return new MainMenuPageObject(webDriver);
        }
    }
}
