using Microsoft.UI.Xaml.Controls;

using ShellLauncher2ConfigurationDesigner.ViewModels;

namespace ShellLauncher2ConfigurationDesigner.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
