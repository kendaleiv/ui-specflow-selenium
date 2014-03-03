using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Web.UI.Tests
{
    [Binding]
    public class WebBrowser
    {
        private const string Key = "browser";
        private static IWebDriver WebDriver;

        public static IWebDriver GetWebDriver()
        {
            if (WebDriver == null)
            {
                // http://stackoverflow.com/a/3461871/941536
                var binFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)
                    .Replace("file:\\", string.Empty);

                WebDriver = new ChromeDriver(binFolderPath);
            }

            if (!ScenarioContext.Current.ContainsKey(Key))
                ScenarioContext.Current.Add(Key, WebDriver);

            return (IWebDriver)ScenarioContext.Current[Key];
        }

        [AfterTestRun]
        public static void CloseBrowser()
        {
            var browser = (IWebDriver)ScenarioContext.Current[Key];
            browser.Quit();
        }
    }
}
