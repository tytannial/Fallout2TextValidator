using System;
using System.IO;

namespace Fallout2TextValidator
{
    static class LogHelper
    {
        private static string path = Directory.GetCurrentDirectory() + "\\";

        public static void Write(string logText, string logfilename)
        {
            string fullpath = string.Format(path + "Logs\\{0}.log", logfilename);
            Directory.CreateDirectory(path + "Logs");
            using (StreamWriter sw = new StreamWriter(fullpath, true))
            {
                sw.WriteLine(logText);
            }
        }

        public static void Write(string logText)
        {
            Write(logText, DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}

