using Avalonia.Controls;
using AvaloniaProject.ViewModels;

namespace AvaloniaProject.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
    
}