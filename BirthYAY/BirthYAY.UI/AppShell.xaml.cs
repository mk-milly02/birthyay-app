using BirthYAY.UI.Views;

namespace BirthYAY.UI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("LoginPage", typeof(LoginPage));
    }
}
