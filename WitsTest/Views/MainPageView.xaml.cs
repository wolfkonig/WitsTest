using WitsTest.ViewModels;

namespace WitsTest
{
    public partial class MainPageView : ContentPage
    {
        public MainPageView(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
