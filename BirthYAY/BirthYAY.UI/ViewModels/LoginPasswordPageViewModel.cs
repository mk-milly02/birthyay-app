using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BirthYAY.UI.ViewModels
{
    internal partial class LoginPasswordPageViewModel : ObservableObject
    {
        [RelayCommand]
        private static async Task Login()
        {
            await Shell.Current.GoToAsync("//Dashboard");
        }
    }
}
