using System.Collections.Generic;
using System.IO;
using System;

namespace SigmaExcel
{
    class Config
    {
        private const string applicationFolderName = "XMLUtility";
        private const string envFile = ".env";
        public static void LoadEnvironmental()
        {
            var envDirectory = GetApplicationFilesDirectory();
            var envPath = envDirectory + @"\" + envFile;
            if (!File.Exists(envPath))
            {
                throw new Exception(".env does not exist");
            }
            using (var reader = new StreamReader(envPath))
            {
                while (!reader.EndOfStream)
                {
                    var envVar = reader.ReadLine().Split('=');
                    Environment.SetEnvironmentVariable(envVar[0], envVar[1]);
                }
            }
        }
        private static string GetApplicationFilesDirectory()
        {
            var serverProgramFilesDirectory =
               Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var applicationFilesDirectory =
                serverProgramFilesDirectory + @"\" + applicationFolderName;
            return applicationFilesDirectory;
        }
    }
}