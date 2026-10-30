using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace AvaloniaProject.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] public partial string Greeting { get; set; } = "Benvenuto in Avalonia! Effettua il Login";
    [ObservableProperty] public partial string Name { get; set; } = string.Empty;
    [ObservableProperty] public partial string SelectedNames { get; set; } = string.Empty;
    [ObservableProperty] public partial string Password { get; set; } = string.Empty;
    [ObservableProperty] public partial string StatusLogin { get; set; } = "LOGIN";
    public ObservableCollection<string> Names { get; set; }
    private bool logged = false;

    [RelayCommand]
    private void Login()
    {
        if (!logged)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Greeting = "Inserisci il tuo nome";
                return;
            }
            Greeting = $"Benvenuto {Name}";
            StatusLogin = "LOGOUT";
            logged = true;
        }
        else
        {
            Greeting = "Arrivederci";
            Name=string.Empty;
            StatusLogin = "LOGIN";
            logged = false;
            
        }
    }
}