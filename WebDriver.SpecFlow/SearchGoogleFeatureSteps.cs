using System;
using TechTalk.SpecFlow;

namespace WebDriver.SpecFlow
{
    [Binding]
    public class SearchGoogleFeatureSteps : BaseStep
    {
        [Given(@"I am on google")]
        public void GivenIAmOnGoogle()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
        }
      
        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchString)
        {
            GoogleSearchPage.SearchForText(searchString);
        }
        
        [Then(@"I get results")]
        public void ThenIGetResults()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
