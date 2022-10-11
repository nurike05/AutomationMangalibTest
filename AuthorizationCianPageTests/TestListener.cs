using NUnit.Framework;
using OpenQA.Selenium;
using Quartz;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace AuthorizationCianPageTests
{
    public class TestListener
    {
        protected IWebDriver Driver;
        private Steps.Steps steps = new Steps.Steps();

        public void TakeScreenshot()
        {
            var browser = steps.InitBrowser();
            string cas = DateTime.Now.ToString("dd_MM_yy_HH_mm_ss");
            Screenshot screenshot = ((ITakesScreenshot)browser).GetScreenshot();
            string filePath = "C:\\Users\\Nurlan_Nurdildauly\\Desktop\\Samples\\" + cas + ".png";
            screenshot.SaveAsFile(filePath);
        }
    }

}
