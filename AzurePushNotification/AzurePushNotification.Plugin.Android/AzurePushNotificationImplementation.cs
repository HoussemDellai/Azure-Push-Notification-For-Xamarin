using System;
using Android.App;
using Android.Util;
using AzurePushNotification.Plugin.Abstractions;
using Gcm.Client;


namespace AzurePushNotification.Plugin
{
    /// <summary>
    /// Implementation for Feature
    /// </summary>
    public class AzurePushNotificationImplementation : IAzurePushNotification
    {

        /// <summary>
        /// References the MainActivity object of the Xamarin.Android project.
        /// </summary>
        public static Activity MainActivityInstance = null;

        /// <summary>
        /// The icon to be shown with notifications.
        /// </summary>
        public static int NotificationIconDrawable = Android.Resource.Drawable.StatNotifyMore;

        /// <summary>
        /// For Android project, obj must be the MainActivity.
        /// </summary>
        /// <param name="obj"></param>
        public void RegisterForAzurePushNotification()
        {

            if (MainActivityInstance == null)
            {

                Log.Info("MainActivityInstance", "MainActivityInstance = null;");

                throw new Exception("You need to set AzurePushNotificationImplementation.MainActivityInstance to your MainActivity inside MainActivity.cs before calling LoadApplication(new App());");
            }

            try
            {
                // Check to ensure everything's set up right
                GcmClient.CheckDevice(MainActivityInstance);
                GcmClient.CheckManifest(MainActivityInstance);

                // Register for push notifications
                Log.Info("MainActivity", "Registering...");

                GcmClient.Register(MainActivityInstance, MyBroadcastReceiver.SENDER_IDS);

                Log.Info("MainActivity", "Completed Registering.");
            }
            catch (Exception exc)
            {
                Log.Info("Exception : ", exc.Message);
            }
        }

        public void UnregisterFromAzurePushNotification()
        {
            if (MainActivityInstance == null)
            {

                Log.Info("MainActivityInstance", "MainActivityInstance = null;");

                throw new Exception("You need to set AzurePushNotificationImplementation.MainActivityInstance to your MainActivity inside MainActivity.cs.");
            }

            try
            {
                // Check to ensure everything's set up right
                GcmClient.CheckDevice(MainActivityInstance);
                GcmClient.CheckManifest(MainActivityInstance);

                // Register for push notifications
                Log.Info("MainActivity", "Unregistering...");

                GcmClient.UnRegister(MainActivityInstance);

                Log.Info("MainActivity", "Completed unregistering.");
            }
            catch (Exception exc)
            {
                Log.Info("Exception : ", exc.Message);
            }
        }
    }
}