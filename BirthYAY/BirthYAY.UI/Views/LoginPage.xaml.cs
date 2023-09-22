using BirthYAY.UI.ViewModels;

namespace BirthYAY.UI.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginPageViewModel();
	}
}