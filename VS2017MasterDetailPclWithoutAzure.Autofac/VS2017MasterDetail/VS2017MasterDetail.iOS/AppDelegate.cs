using Foundation;
using UIKit;

//PRISM-CONVERSION-NOTE: The Prism.Autofac.Forms NuGet package (and all dependencies) were added
//  to this project, in order to use Prism for Xamarin.Forms functionality.
//Usings needed for Prism -
using Prism.Autofac.Forms;

namespace VS2017MasterDetail.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

            //PRISM-CONVERSION-NOTE: Now initializing our App instance with a new platform-specific
            //  initializer that is declared below.
            LoadApplication(new App(new iOSInitializer()));

			return base.FinishedLaunching(app, options);
		}
	}

    //PRISM-CONVERSION-NOTE: Platform-specific application initializer for any custom type registrations.
    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IAutofacContainer container)
        {
            //In the future, if we have any iOS-specific navigation or dependency registrations that need to
            //  be made during application initialization, we can do that here - e.g.:
            //container.RegisterType<iOSCustomService>().As<IPlatformCustomService>();
        }
    }
}
