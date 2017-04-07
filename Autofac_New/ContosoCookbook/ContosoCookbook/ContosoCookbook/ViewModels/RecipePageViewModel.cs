using System;
using ContosoCookbook.Business;
using Prism.Navigation;

namespace ContosoCookbook.ViewModels
{
    public class RecipePageViewModel : ViewModelBase, INavigationAware
    {
        private Recipe _recipe;
        public Recipe Recipe
        {
            get { return _recipe; }
            set { SetProperty(ref _recipe, value); }
        }

        public RecipePageViewModel()
        {

        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("recipe"))
                Recipe = (Recipe)parameters["recipe"];
        }
    }
}