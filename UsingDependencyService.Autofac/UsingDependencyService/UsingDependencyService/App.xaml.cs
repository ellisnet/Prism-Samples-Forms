using Prism.Autofac;
using Prism.Autofac.Forms;
using UsingDependencyService.Services;
using UsingDependencyService.Views;

namespace UsingDependencyService
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();

            //The Autofac version of Prism.Forms does not resolve dependencies directly from the Xamarin.Forms
            // DependencyService, so the following line re-registers the dependency in the Prism Autofac container
            (Container as IAutofacContainer)?.Register(ctx => Xamarin.Forms.DependencyService.Get<ITextToSpeech>())
                .As<ITextToSpeech>();
        }
    }
}
