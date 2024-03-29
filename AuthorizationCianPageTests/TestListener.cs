﻿using NUnit.Framework;
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
            string time = DateTime.Now.ToString("dd_MM_yy_HH_mm_ss");
            Screenshot screenshot = ((ITakesScreenshot)browser).GetScreenshot();
            string filePath = "C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\Artifact Genarator\\" + time + ".png";
            screenshot.SaveAsFile(filePath);
        }
    }

}
