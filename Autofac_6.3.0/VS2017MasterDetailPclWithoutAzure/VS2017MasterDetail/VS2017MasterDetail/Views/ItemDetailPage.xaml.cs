//using VS2017MasterDetail.ViewModels; - no longer needed

using Xamarin.Forms;

namespace VS2017MasterDetail.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();
        }

        //PRISM-CONVERSION-NOTE: The following logic has been moved to the ItemDetailViewModel class -
        //ItemDetailViewModel viewModel;
        //public ItemDetailPage(ItemDetailViewModel viewModel)
        //{
        //    InitializeComponent();

        //    BindingContext = this.viewModel = viewModel;
        //}
    }
}
