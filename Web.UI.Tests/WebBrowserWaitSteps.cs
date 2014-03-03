using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Web.UI.Tests
{
    [Binding]
    public class WebBrowserWaitSteps : WebDriverStepsBase
    {
        [When("I wait for element with id (.*) to exist")]
        public void IWaitForElementWithIdToExist(string id)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            wait.Until<IWebElement>(ExpectedConditions.ElementExists(By.Id(id)));
        }

        [Then(@"I expect that the element with id (.*) exists")]
        public void ThenIExpectThatTheElementWithIdExists(string id)
        {
            var element = Driver.FindElement(By.Id(id));

            Assert.NotNull(element);
        }
    }
}
