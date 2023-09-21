using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BirthYAY.UI.ViewModels
{
    internal partial class WelcomePageViewModel : ObservableObject
    {
        [RelayCommand]
        private static async Task GetStarted()
        {
            await Shell.Current.GoToAsync("LoginPage");
        }
    }
}
