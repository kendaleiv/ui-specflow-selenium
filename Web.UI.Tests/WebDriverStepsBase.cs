using OpenQA.Selenium;
using System.Configuration;

namespace Web.UI.Tests
{
    public abstract class WebDriverStepsBase
    {
        protected static readonly string AppRootUrl = ConfigurationManager.AppSettings["AppRoot"];
        protected readonly IWebDriver Driver = WebBrowser.GetWebDriver();
    }
}
