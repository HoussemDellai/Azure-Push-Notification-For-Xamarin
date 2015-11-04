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
        /// References the MainActivity object of the Xamarin.Android project.
        /// </summary>
        public static Activity MainActivityInstance = null;

        /// <summary>
        /// For Android project, obj must be the MainActivity.
        /// </summary>
        /// <param name="obj"></param>
        public void RegisterForAzurePushNotification()
        {

            if (MainActivityInstance == null)
            {

                Log.Info("MainActivityInstance", "MainActivityInstance = null;");

                throw new Exception("You need to set AzurePushNotificationForXamarinFormsImplementation.MainActivityInstance to your MainActivity inside MainActivity.cs.");
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

                throw new Exception("You need to set AzurePushNotificationForXamarinFormsImplementation.MainActivityInstance to your MainActivity inside MainActivity.cs.");
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