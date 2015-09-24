# Azure Push Notification For Xamarin

This plugin makes it easy to register to Microsoft Azure Push Notifications from a Xamarin project. This supports using Tags.

The supported projects are:
- Xamarin.Android
- Windows Phone 8.1 RT
- Windows Phone Silverlight
- Windows Store 8

The resulted Nuget Package is published on Nuget website</br>
https://www.nuget.org/packages/Xam.Plugin.AzurePushNotification/</br>
And could be installed inside your project via Nuget Package Manager or via the Package Manager Console:</br>
PM> Install-Package Xam.Plugin.AzurePushNotification</br>

<h3>How to use it</h3>

1 - Install the nuget package Xam.Plugin.AzurePushNotification on each of your Xamarin.Android, Windows Store, Windows Phone (Silverlight and RT) projects.</br>
2 - Register to Azure Push Notification.
<h4>a - For Xamarin.Android</h4>
  - You will need to get an API Key for Google Cloud Messaging. This link have all the details on how to do that:
  https://azure.microsoft.com/en-us/documentation/articles/partner-xamarin-notification-hubs-android-get-started/#register
  - And you will need to configure your Notification Hub for GCM:
  https://azure.microsoft.com/en-us/documentation/articles/partner-xamarin-notification-hubs-android-get-started/#configure-hub
  - Set the following properties inside your app manifest : app name, package name, version number and version name.
  - Then, in your MainActivity.cs, inside OnCreate(), add the following code:
  
  PushNotificationCredentials.Tags = new[] { "Tag1", "Tag2" };//Just let it empty if you want not to use tags.</br>
  PushNotificationCredentials.GoogleApiSenderId = "GoogleApiSenderId";</br>
  PushNotificationCredentials.AzureNotificationHubName = "AzureNotificationHubName";</br>
  PushNotificationCredentials.AzureListenConnectionString = "AzureListenConnectionString";</br>
  new AzurePushNotificationForXamarinFormsImplementation().RegisterForAzurePushNotification(this);//this will pass an instance of the MainActivity required to register for GCM.
  
<h4>b - For Windows Store and Windows Phone 8.1 RT</h4>
  - Register your app for the Windows Store:
  https://azure.microsoft.com/en-us/documentation/articles/notification-hubs-windows-store-dotnet-get-started/#register-your-app-for-the-windows-store
  - configure your Notification Hub for Windows:
  https://azure.microsoft.com/en-us/documentation/articles/notification-hubs-windows-store-dotnet-get-started/#configure-your-notification-hub
  - In the package.appxmanifest, make sue that 'Toast capable' is set to 'Yes'.
  - Add the following code inside your app.cs, OnLaunched() method:</br>
  PushNotificationCredentials.Tags = new[] { "Tag1", "Tag2" };</br>
  PushNotificationCredentials.AzureNotificationHubName = "AzureNotificationHubName";</br>
  PushNotificationCredentials.AzureListenConnectionString = "AzureListenConnectionString";</br>
  new AzurePushNotificationForXamarinFormsImplementation().RegisterForAzurePushNotification(null);</br>

<h4>c - For Windows Phone 8/8.1 Silverlight</h4>
  - configure your Notification Hub for Windows Phone Silverlight:
  https://azure.microsoft.com/en-us/documentation/articles/notification-hubs-windows-phone-get-started/#create-your-notification-hub
  - WMAppManifest.xml file, click the Capabilities tab, and make sure that the ID_CAP_PUSH_NOTIFICATION capability is checked.
  - Add the following code inside your app.cs constructor:</br>
  PushNotificationCredentials.Tags = new[] { "Tag1", "Tag2" };</br>
  PushNotificationCredentials.AzureNotificationHubName = "AzureNotificationHubName";</br>
  PushNotificationCredentials.AzureListenConnectionString = "AzureListenConnectionString";</br>
  new AzurePushNotificationForXamarinFormsImplementation().RegisterForAzurePushNotification(null);</br>

