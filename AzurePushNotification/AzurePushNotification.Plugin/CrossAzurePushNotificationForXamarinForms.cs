using System;
using AzurePushNotificationForXamarinForms.Plugin.Abstractions;

namespace AzurePushNotificationForXamarinForms.Plugin
{
    /// <summary>
    /// Cross platform AzurePushNotificationForXamarinForms implemenations
    /// </summary>
    public class CrossAzurePushNotificationForXamarinForms
  {
    static Lazy<IAzurePushNotificationForXamarinForms> Implementation = new Lazy<IAzurePushNotificationForXamarinForms>(() => CreateAzurePushNotificationForXamarinForms(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static IAzurePushNotificationForXamarinForms Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static IAzurePushNotificationForXamarinForms CreateAzurePushNotificationForXamarinForms()
    {
#if PORTABLE
        return null;
#else
        return new AzurePushNotificationForXamarinFormsImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
      return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
