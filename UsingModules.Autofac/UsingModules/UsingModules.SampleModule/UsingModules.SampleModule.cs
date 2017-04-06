using Prism.Autofac.Forms;
using Prism.Modularity;
using UsingModules.SampleModule.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace UsingModules.SampleModule
{
    public class SampleModule : IModule, IPreRegisterTypes
    {
        private readonly IAutofacContainer _container;
        public SampleModule(IAutofacContainer container)
        {
            //Need to keep this constructor very light because it will be called
            //  on app start in order to run the RegisterTypes() method -
            //  so move logic to Initialize() instead.
            _container = container;
        }

        public void Initialize()
        {
            //We can no longer register types here, because Initialize() will be called
            //  after our immutable Autofac container has already been built.

            //_container.RegisterTypeForNavigation<SamplePage>();
        }

        public void RegisterTypes(IAutofacContainer container)
        {
            //Instead we are implementing IPreRegisterTypes and putting our type registration here
            container.RegisterTypeForNavigation<SamplePage>();            
        }
    }
}
