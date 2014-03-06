using TechTalk.SpecFlow;
using Web.UI.Tests.IISExpress;

namespace Web.UI.Tests
{
    [Binding]
    public class InitAndTeardownSteps
    {
        private static IISExpressHost _webServer = IISExpressHostFactory.CreateDefaultInstance();

        [BeforeTestRun]
        public static void LaunchIISExpress()
        {
            _webServer.Start();
        }

        [AfterTestRun]
        public static void CloseIISExpress()
        {
            _webServer.Stop();
        }
    }
}
