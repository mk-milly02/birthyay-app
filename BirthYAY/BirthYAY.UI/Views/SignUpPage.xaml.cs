using BirthYAY.UI.ViewModels;

namespace BirthYAY.UI.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
		BindingContext = new SignUpPageViewModel();
	}
}