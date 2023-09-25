using BirthYAY.UI.ViewModels;

namespace BirthYAY.UI.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel();
	}
}