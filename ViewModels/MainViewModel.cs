using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaProject.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] public partial string Greeting { get; set; } = "Benvenuto in Avalonia! Effettua il Login";
    [ObservableProperty] public partial string Name { get; set; } = string.Empty;
    [ObservableProperty] public partial string StatusLogin { get; set; } = "LOGGED";
    private bool logged;

    [RelayCommand]
    private void Login()
    {
        if (!logged)
        {
            Greeting = $"Benvenuto {Name}";
            StatusLogin = "LOGOUT";
            logged = true;
        }
        else
        {
            Greeting = "Arrivederci";
            StatusLogin = "LOGIN";
            logged = false;
        }
    }
}