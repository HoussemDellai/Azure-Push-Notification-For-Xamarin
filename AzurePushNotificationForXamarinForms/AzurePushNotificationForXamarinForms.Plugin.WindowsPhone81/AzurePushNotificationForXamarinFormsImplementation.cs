using AzurePushNotificationForXamarinForms.Plugin.Abstractions;
using System;
using Windows.Networking.PushNotifications;
using Microsoft.WindowsAzure.Messaging;


namespace AzurePushNotificationForXamarinForms.Plugin
{
    /// <summary>
    /// Implementation for AzurePushNotificationForXamarinForms
    /// </summary>
    public class AzurePushNotificationForXamarinFormsImplementation : IAzurePushNotificationForXamarinForms
    {
        public async void RegisterForAzurePushNotification()
        {
            var channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();

            var hub = new NotificationHub(PushNotificationCredentials.AzureNotificationHubName,
                PushNotificationCredentials.AzureListenConnectionString);

            await hub.RegisterNativeAsync(channel.Uri, PushNotificationCredentials.Tags);
        }
    }
}