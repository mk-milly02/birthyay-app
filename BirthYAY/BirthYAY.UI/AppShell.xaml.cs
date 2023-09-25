using BirthYAY.UI.Views;

namespace BirthYAY.UI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
		Routing.RegisterRoute("SignUpPage", typeof(SignUpPage));
		Routing.RegisterRoute("LoginPasswordPage", typeof(LoginPasswordPage));
		Routing.RegisterRoute("HomePage", typeof(HomePage));
    }
}
