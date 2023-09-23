using BirthYAY.UI.ViewModels;

namespace BirthYAY.UI.Views;

public partial class LoginPasswordPage : ContentPage
{
	public LoginPasswordPage()
	{
		InitializeComponent();
		BindingContext = new LoginPasswordPageViewModel();
	}
}