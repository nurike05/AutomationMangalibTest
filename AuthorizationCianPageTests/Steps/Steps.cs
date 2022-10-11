using AuthorizationCianPageTests.Model;
using AuthorizationCianPageTests.PageObjects;
using AuthorizationCianPageTests.Service;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

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
            //mainMenu.SignIn().Login(UserNameForTests.GetUserName(), UserNameForTests.GetPassword());
            mainMenu.SignIn().Login(testUser);
        }

        public string CheckUserName()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            return mainMenu.CheckUserProfile();
        }
    }
}
