using AzurePushNotificationForXamarinForms.Plugin.Abstractions;
using System;


namespace AzurePushNotificationForXamarinForms.Plugin
{
  /// <summary>
  /// Implementation for AzurePushNotificationForXamarinForms
  /// </summary>
  public class AzurePushNotificationForXamarinFormsImplementation : IAzurePushNotificationForXamarinForms
  {
      public void RegisterForAzurePushNotification(object obj)
      {
          
      }

      public void RegisterForAzurePushNotification(PushNotificationCredentials pushNotificationCredentials, object obj)
      {
          throw new NotImplementedException();
      }
  }
}