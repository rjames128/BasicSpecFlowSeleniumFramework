using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebDriver.PageObjects
{
    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            webDriver = driver;
        }
        private static IWebDriver webDriver;

        public static IWebDriver Driver {
            get
            {
                return webDriver;
            }
        }
    }
}
