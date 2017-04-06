using System;
using System.Collections.Generic;
using Prism.Navigation;
using Prism.Mvvm;

using Xamarin.Forms;

using Autofac;
using Prism.Autofac.Forms;

namespace TabbedNavigation.Views
{
    public partial class DynamicTabbedPage : TabbedPage, INavigatingAware
    {
        IAutofacContainer _container { get; }

        public DynamicTabbedPage(IAutofacContainer container)
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
            var page = _container.ResolveNamed<Page>(name);

            if(ViewModelLocator.GetAutowireViewModel(page) == null)
                ViewModelLocator.SetAutowireViewModel(page, true);

            (page as INavigatingAware)?.OnNavigatingTo(parameters);
            (page?.BindingContext as INavigatingAware)?.OnNavigatingTo(parameters);

            Children.Add(page);
        }
    }
}
