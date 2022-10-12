using AuthorizationCianPageTests.Model;
using AuthorizationCianPageTests.PageObjects;
using AuthorizationCianPageTests.Service;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace AuthorizationCianPageTests.Steps
{
    public class Steps
    {
        IWebDriver driver;
        User testUser = UserCreator.SetWithCredentialsFromProperty();

        public IWebDriver InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
            return driver;
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
            driver = null;
        }

        public void LoginMangalib()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.SignIn().Login(testUser);
        }
        public void LoginMangalibViaXml()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.SignIn().Login(testUser.GetUsernameFromProp, testUser.GetPasswordFromProp);
        }

        public void LoginMangalib(string login, string password)
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            mainMenu.OpenPage();
            mainMenu.SignIn().Login(login, password);
        }

        public string CheckUserName()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            return mainMenu.CheckUserProfile();
        }
    }
}
