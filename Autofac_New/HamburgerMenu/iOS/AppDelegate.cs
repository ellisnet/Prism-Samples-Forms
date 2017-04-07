using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using Prism.Autofac.Forms;
using UIKit;

namespace HamburgerMenu.iOS
{
    [Register( "AppDelegate" )]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching( UIApplication app, NSDictionary options )
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication( new App(new iOSInitializer()) );

            return base.FinishedLaunching( app, options );
        }
    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IAutofacContainer container)
        {

        }
    }
}
