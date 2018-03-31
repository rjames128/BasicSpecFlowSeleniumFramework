using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.PageObjects;

namespace WebDriver.SpecFlow
{
    public class BaseStep
    {
        public static IWebDriver Driver { get; set; }
        private GoogleSearchPage googleSearchPage;

        public GoogleSearchPage GoogleSearchPage
        {
            get
            {
                if (googleSearchPage == null)
                    googleSearchPage = new GoogleSearchPage(Driver);
                return googleSearchPage;
            }
        }
    }
}
