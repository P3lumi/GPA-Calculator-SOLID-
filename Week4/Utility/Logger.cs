using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Week4.Utility
{
    public static class Logger
    {
        private static string path = @"C:\Users\hp\Documents\logs.txt";
        static FileInfo _file = new FileInfo(path);
        
        public static void Log(string error, string message)
        {
            using (StreamWriter logger = new StreamWriter(_file.Open(FileMode.Append, FileAccess.Write)))
            {
                logger.WriteLine(error);
                logger.WriteLine($"{message}\n");
                logger.Close();
            }
        }
    }
}
