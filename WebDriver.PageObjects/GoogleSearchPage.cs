using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriver.PageObjects
{
    public class GoogleSearchPage :BasePage
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver) { }
        
        IWebElement searchText => Driver.FindElement(By.Id("lst-ib"));
        IWebElement searchButton => Driver.FindElement(By.Name("btnK"));

        public void SearchForText(string searchString)
        {
            searchText.SendKeys(searchString);
            searchButton.Click();
        }
    }
}
