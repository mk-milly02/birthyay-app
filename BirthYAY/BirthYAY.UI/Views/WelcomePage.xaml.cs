using BirthYAY.UI.ViewModels;

namespace BirthYAY.UI.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
		BindingContext = new WelcomePageViewModel();
	}
}