using System;
using Windows.Networking.PushNotifications;
using AzurePushNotification.Plugin.Abstractions;
using Microsoft.WindowsAzure.Messaging;


namespace AzurePushNotification.Plugin
{
  /// <summary>
  /// Implementation for AzurePushNotificationForXamarinForms
  /// </summary>
  public class AzurePushNotificationImplementation : IAzurePushNotification
  {
        public async void RegisterForAzurePushNotification()
        {
            var channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();

            var hub = new NotificationHub(PushNotificationCredentials.AzureNotificationHubName,
                PushNotificationCredentials.AzureListenConnectionString);

            await hub.RegisterNativeAsync(channel.Uri, PushNotificationCredentials.Tags);
        }

        public async void UnregisterFromAzurePushNotification()
        {
            var channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();

            var hub = new NotificationHub(PushNotificationCredentials.AzureNotificationHubName,
                PushNotificationCredentials.AzureListenConnectionString);

            await hub.UnregisterNativeAsync();
        }
    }
}