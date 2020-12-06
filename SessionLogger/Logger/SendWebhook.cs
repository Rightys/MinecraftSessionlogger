using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace SessionLogger.Logger
{
    class SendWebhook
    {
        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    msg
                }
            });
        }
    }
}
