using WitsTest.ViewModels;

namespace WitsTest.Views;

public partial class WelcomeView : ContentPage
{
	public WelcomeView(WelcomeViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}