using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Prism.Autofac.Forms;
using UsingDependencyService.Services;
using UsingDependencyService.UWP.Services;

namespace UsingDependencyService.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new UsingDependencyService.App(new UwpInitializer()));
        }
    }

    public class UwpInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IAutofacContainer container)
        {
            //One option would be to register the ITextToSpeech implementation here - this does not
            // use or require the Xamarin.Forms DependencyService.
            // But since the platform-specific implementation of ITextToSpeech *is* registered with
            // the DependencyService, the Autofac registration is being done in the portable library.
            
            //container.RegisterType<TextToSpeech_UWP>().As<ITextToSpeech>();
        }
    }
}
