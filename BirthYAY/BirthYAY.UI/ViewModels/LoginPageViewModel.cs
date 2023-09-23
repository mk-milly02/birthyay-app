using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BirthYAY.UI.ViewModels
{
    partial class LoginPageViewModel : ObservableObject
    {
        [RelayCommand]
        private static async Task GoToSignUpPage()
        {
            await Shell.Current.GoToAsync("SignUpPage");
        }

        [RelayCommand]
        private static async Task Continue()
        {
            await Shell.Current.GoToAsync("LoginPasswordPage");
        }
    }
}
