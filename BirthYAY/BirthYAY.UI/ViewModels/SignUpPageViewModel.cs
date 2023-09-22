using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BirthYAY.UI.ViewModels
{
    partial class SignUpPageViewModel : ObservableObject
    {
        [RelayCommand]
        private static async Task GoToLoginPage()
        {
            await Shell.Current.GoToAsync("LoginPage");
        }
    }
}
