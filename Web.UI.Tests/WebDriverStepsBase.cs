using OpenQA.Selenium;
using Web.UI.Tests.IISExpress;

namespace Web.UI.Tests
{
    public abstract class WebDriverStepsBase
    {
        protected static readonly string AppRootUrl = IISExpressHostFactory.CreateDefaultInstance().BaseUrl;
        protected readonly IWebDriver Driver = WebBrowser.GetWebDriver();
    }
}
