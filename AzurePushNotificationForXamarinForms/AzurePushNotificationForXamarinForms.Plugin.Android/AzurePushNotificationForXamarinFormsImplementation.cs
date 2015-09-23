using AzurePushNotificationForXamarinForms.Plugin.Abstractions;
using System;
using Android.App;
using Android.Util;
using Gcm.Client;


namespace AzurePushNotificationForXamarinForms.Plugin
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class AzurePushNotificationForXamarinFormsImplementation : IAzurePushNotificationForXamarinForms
    {
        /// <summary>
        /// For Android project, obj must be the MainActivity.
        /// </summary>
        /// <param name="obj"></param>
        public void RegisterForAzurePushNotification(object obj)
        {

            var mainActivity = (Activity) obj;

            try
            {
                // Check to ensure everything's set up right
                GcmClient.CheckDevice(mainActivity);
                GcmClient.CheckManifest(mainActivity);

                // Register for push notifications
                Log.Info("MainActivity", "Registering...");

                GcmClient.Register(mainActivity, MyBroadcastReceiver.SENDER_IDS);//PushNotifications.Constants.SenderID);
            }
            catch (Exception exc)
            {
                Log.Info("Exception : ", exc.Message);
            }
        }
    }
}