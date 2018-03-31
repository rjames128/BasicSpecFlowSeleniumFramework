using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace WebDriver.SpecFlow
{
    [Binding]
    public sealed class CommonSteps : BaseStep
    {
        [BeforeScenario("Chrome")]
        public void SetupChromeDriver()
        {
            Driver = new ChromeDriver();
        }

        [BeforeScenario("IE")]
        public void SetupIEDriver()
        {
            Driver = new InternetExplorerDriver();
        }
    }
}
