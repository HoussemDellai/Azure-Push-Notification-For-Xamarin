using System;
using AzurePushNotification.Plugin.Abstractions;
using Microsoft.Phone.Notification;
using Microsoft.WindowsAzure.Messaging;


namespace AzurePushNotification.Plugin
{
  /// <summary>
  /// Implementation for AzurePushNotification
  /// </summary>
  public class AzurePushNotificationImplementation : IAzurePushNotification
  {
      public void RegisterForAzurePushNotification()
      {
            var channel = HttpNotificationChannel.Find("MyPushChannel");
            if (channel == null)
            {
                channel = new HttpNotificationChannel("MyPushChannel");
                channel.Open();
                channel.BindToShellToast();
            }

            channel.ChannelUriUpdated += async (o, args) =>
            {
                var hub = new NotificationHub(PushNotificationCredentials.AzureNotificationHubName, PushNotificationCredentials.AzureListenConnectionString);

                await hub.RegisterNativeAsync(args.ChannelUri.ToString(), PushNotificationCredentials.Tags);
            };
        }

      public void UnregisterFromAzurePushNotification()
      {
            var channel = HttpNotificationChannel.Find("MyPushChannel");
            if (channel == null)
            {
                channel = new HttpNotificationChannel("MyPushChannel");
                channel.Open();
                channel.BindToShellToast();
            }

            channel.ChannelUriUpdated += async (o, args) =>
            {
                var hub = new NotificationHub(PushNotificationCredentials.AzureNotificationHubName, PushNotificationCredentials.AzureListenConnectionString);

                await hub.UnregisterNativeAsync();
                await hub.UnregisterAllAsync(args.ChannelUri.ToString());
            };
        }
  }
}