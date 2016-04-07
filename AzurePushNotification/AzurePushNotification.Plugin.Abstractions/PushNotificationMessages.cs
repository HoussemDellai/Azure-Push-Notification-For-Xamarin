using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzurePushNotification.Plugin.Abstractions
{
    public class PushNotificationMessages
    {

        public static string RegistrationMessage { get; set; }
        public static string RegistrationMessageDescription { get; set; }
        public static bool IsShowRegistrationMessage { get; set; }

        public static string UnregistrationMessage { get; set; }

        public static string UnregistrationMessageDescription { get; set; }

        public static string ReceivedMessage { get; set; }
    }
}
