using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Autofac;
using Prism.Autofac.Forms;
using UsingDependencyService.iOS.Services;
using UsingDependencyService.Services;

namespace UsingDependencyService.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            Prism.Autofac.PrismApplication.ContainerType = AutofacContainerType.Immutable;
            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }
    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainer container)
        {
            //One option would be to register the ITextToSpeech implementation here - this does not
            // use or require the Xamarin.Forms DependencyService.
            // But since the platform-specific implementation of ITextToSpeech *is* registered with
            // the DependencyService, the Autofac registration is being done in the portable library.
            //(container as IAutofacContainer)?.RegisterType<TextToSpeech_iOS>().As<ITextToSpeech>();
        }
    }
}
