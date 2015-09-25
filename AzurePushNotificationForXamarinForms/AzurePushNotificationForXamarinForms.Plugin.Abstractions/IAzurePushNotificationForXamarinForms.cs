using System;

namespace AzurePushNotificationForXamarinForms.Plugin.Abstractions
{
    /// <summary>
    /// Interface for AzurePushNotificationForXamarinForms
    /// </summary>
    public interface IAzurePushNotificationForXamarinForms
    {

        /// <summary>
        /// Registers for Azure Push Notification using 
        /// the credentials provided in PushNotificationCredentials class.
        /// </summary>
        void RegisterForAzurePushNotification();
    }
}
