using System;
using System.Collections.Generic;
using Autofac;
using Prism.Navigation;
using Prism.Mvvm;

using Xamarin.Forms;

namespace TabbedNavigation.Views
{
    public partial class DynamicTabbedPage : TabbedPage, INavigatingAware
    {
        IContainer _container { get; }

        public DynamicTabbedPage(IContainer container)
        {
            InitializeComponent();
            _container = container;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            System.Diagnostics.Debug.WriteLine($"{Title} OnNavigatingTo");
            var tabs = parameters.GetValues<string>("addTab");
            foreach(var name in tabs)
                AddChild(name, parameters);
        }

        private void AddChild(string name, NavigationParameters parameters)
        {
            //var page = _container.Resolve<object>(name) as Page;
            var page = _container.ResolveNamed<Page>(name);

            if(ViewModelLocator.GetAutowireViewModel(page) == null)
                ViewModelLocator.SetAutowireViewModel(page, true);

            (page as INavigatingAware)?.OnNavigatingTo(parameters);
            (page?.BindingContext as INavigatingAware)?.OnNavigatingTo(parameters);

            Children.Add(page);
        }
    }
}
