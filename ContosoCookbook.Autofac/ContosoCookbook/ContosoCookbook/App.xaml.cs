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
            //Container.RegisterType<IRecipeService, RecipeService>(new ContainerControlledLifetimeManager());

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<RecipePage>();

            //var builder = new ContainerBuilder();

            //builder.RegisterType<RecipeService>().As<IRecipeService>().SingleInstance();

            //builder.Update(Container);
            (Container as IAutofacContainer)?.RegisterType<RecipeService>().As<IRecipeService>().SingleInstance();
        }
    }
}
