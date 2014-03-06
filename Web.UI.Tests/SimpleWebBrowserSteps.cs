using OpenQA.Selenium;
using System;
using System.IO;
using TechTalk.SpecFlow;
using Xunit;

namespace Web.UI.Tests
{
    [Binding]
    public class SimpleWebBrowserSteps : WebDriverStepsBase
    {
        [Given(@"I am on the (.*) page")]
        public void IAmOnThePage(string relativeUrl)
        {
            var url = GetFullUrl(relativeUrl);
            Driver.Navigate().GoToUrl(url);
        }

        [When(@"I click (.*) on the navbar")]
        public void WhenIClickOnTheNavbar(string linkText)
        {
            var nav = Driver.FindElement(By.ClassName("nav"));
            var link = nav.FindElement(By.LinkText(linkText));

            link.Click();
        }

        [Then(@"I expect to see the text (.*)")]
        public void IExpectToSeeTheText(string text)
        {
            Assert.Contains(text, Driver.PageSource);
        }

        [Then(@"I expect to be at the (.*) page")]
        public void ThenIExpectToBeAtThePage(string relativeUrl)
        {
            var url = GetFullUrl(relativeUrl);
            Assert.Equal(url, Driver.Url);
        }

        private static string GetFullUrl(string relativeUrl)
        {
            var uri = new Uri(Path.Combine(AppRootUrl, relativeUrl.TrimStart('/')).Replace("\\", "/"));
            return uri.AbsoluteUri;
        }
    }
}
