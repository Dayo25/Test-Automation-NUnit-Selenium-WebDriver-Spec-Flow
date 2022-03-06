using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumSpecflowProject.Steps
{
    [Binding]
   public class AdminDemoProductSearchSteps
    {
        [Given(@"User is Logged in to the website")]
        public void GivenUserIsLoggedInToTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User navigate to the Products page under Catalogue")]
        public void WhenUserNavigateToTheProductsPageUnderCatalogue()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"User chooses Show (.*) items")]
        public void WhenUserChoosesShowItems(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the following (.*) items are displayed")]
        public void ThenTheFollowingItemsAreDisplayed(int p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
