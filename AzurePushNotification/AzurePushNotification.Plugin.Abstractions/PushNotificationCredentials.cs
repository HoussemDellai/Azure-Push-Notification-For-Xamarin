

namespace AzurePushNotification.Plugin.Abstractions
{
    /// <summary>
    /// Contains credentials for accessing Microsoft Azure Push Notifications 
    /// and Google Cloud Messaging.
    /// </summary>
    public class PushNotificationCredentials
    {

        /// <summary>
        /// Google API Project Number.
        /// </summary>
        public static string GoogleApiSenderId = ""; // 

        /// <summary>
        /// The name of the Azure Notification Hub created inside Azure portal.
        /// </summary>
        public static string AzureNotificationHubName = "";

        /// <summary>
        /// The listen connection string found under "Connection Information" 
        /// of the Notification Hub.
        /// </summary>
        public static string AzureListenConnectionString = "";

        ///// <summary>
        ///// Google API Project Number.
        ///// </summary>
        //public static string GoogleApiSenderId = "536442481057"; 

        ///// <summary>
        ///// The name of the Azure Notification Hub created inside Azure portal.
        ///// </summary>
        //public static string AzureNotificationHubName = "haltaalamnotificationhub";

        ///// <summary>
        ///// The listen connection string found under "Connection Information" 
        ///// of the Notification Hub.
        ///// </summary>
        //public static string AzureListenConnectionString = "Endpoint=sb://haltaalam.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=iPouaer4JOoK2w8EHALyCWCmRwnLYP/MapP+YkYeZF8=";

        /// <summary>
        /// The tags to register for with Azure Push Notifications.
        /// </summary>
        public static string[] Tags = new string[0];
    }
}