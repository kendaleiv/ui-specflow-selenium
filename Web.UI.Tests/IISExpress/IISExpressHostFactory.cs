using System;
using System.Configuration;
using System.IO;

namespace Web.UI.Tests.IISExpress
{
    public class IISExpressHostFactory
    {
        public static IISExpressHost CreateDefaultInstance()
        {
            var targetProjectFolderName = ConfigurationManager.AppSettings["TargetProjectFolderName"];
            var applicationPath = GetApplicationPath(targetProjectFolderName);

            var portNumber = Convert.ToInt32(ConfigurationManager.AppSettings["WebServerPort"]);

            return new IISExpressHost(applicationPath, portNumber);
        }

        private static string GetApplicationPath(string targetProjectFolderName)
        {
            var solutionRootDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var applicationPath = Path.Combine(solutionRootDir, targetProjectFolderName);

            return applicationPath;
        }
    }
}
