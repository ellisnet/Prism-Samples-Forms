using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace HamburgerMenu.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main( string[] args )
        {
            //TODO: Not sure why I get an unhandled exception here with version 6.3.0 of Prism.Autofac.Forms
            UIApplication.Main( args, null, "AppDelegate" );
        }
    }
}
