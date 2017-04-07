using Autofac;
using Prism.Autofac.Forms;
using Prism.Modularity;
using UsingModules.SampleModule.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace UsingModules.SampleModule
{
    public class SampleModule : IModule
    {
        private readonly IContainer _container;
        public SampleModule(IContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<SamplePage>();
        }
    }
}
