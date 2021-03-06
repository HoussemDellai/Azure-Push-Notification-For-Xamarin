﻿using System;

namespace AzurePushNotification.Plugin.Abstractions
{
    /// <summary>
    /// Interface for AzurePushNotificationForXamarinForms
    /// </summary>
    public interface IAzurePushNotification
    {

        /// <summary>
        /// Registers for Azure Push Notification using 
        /// the credentials provided in PushNotificationCredentials class.
        /// </summary>
        void RegisterForAzurePushNotification();

        /// <summary>
        /// Unregisters from Azure Push Notification using 
        /// the credentials provided in PushNotificationCredentials class.
        /// </summary>
        void UnregisterFromAzurePushNotification();
    }
}
