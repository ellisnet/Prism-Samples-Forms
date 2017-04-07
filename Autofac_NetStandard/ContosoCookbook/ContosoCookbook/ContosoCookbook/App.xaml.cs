using Xamarin.Forms;
using ContosoCookbook.Views;
using ContosoCookbook.Services;

using Prism.Autofac;
using Prism.Autofac.Forms;

namespace ContosoCookbook
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<RecipePage>();

            Container.RegisterType<RecipeService>().As<IRecipeService>().SingleInstance();
        }
    }
}
