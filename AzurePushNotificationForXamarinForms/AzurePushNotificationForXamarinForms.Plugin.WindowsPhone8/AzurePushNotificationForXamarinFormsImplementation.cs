using AzurePushNotificationForXamarinForms.Plugin.Abstractions;
using System;
using Microsoft.Phone.Notification;
using Microsoft.WindowsAzure.Messaging;


namespace AzurePushNotificationForXamarinForms.Plugin
{
  /// <summary>
  /// Implementation for AzurePushNotificationForXamarinForms
  /// </summary>
  public class AzurePushNotificationForXamarinFormsImplementation : IAzurePushNotificationForXamarinForms
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
  }
}