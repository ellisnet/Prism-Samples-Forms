﻿using System;
using Autofac;
using Prism.Modularity;
using Prism.Autofac;
using Prism.Autofac.Forms;
using UsingModules.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace UsingModules
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            var navigationPage = "MainNavigationPage/MainPage";
            NavigationService.NavigateAsync($"{navigationPage}?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainNavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();

            //Register any types needed for module instantiation
            var builder = new ContainerBuilder();

            //It seems like registering IContainer should be handled by the Prism.Autofac.Forms library itself.
            builder.Register(c => this.Container).As<IContainer>();

            builder.Update(Container);
        }

        protected override void ConfigureModuleCatalog()
        {
            Type sampleModuleType = typeof(SampleModule.SampleModule);
            ModuleCatalog.AddModule(
              new ModuleInfo()
              {
                  ModuleName = sampleModuleType.Name,
                  ModuleType = sampleModuleType,
                  InitializationMode = InitializationMode.OnDemand
              });
        }
    }
}
