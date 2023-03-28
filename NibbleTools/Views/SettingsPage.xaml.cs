using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class SettingsPage : Page
{
    public SettingsPage()
    {
        ViewModel = App.GetService<SettingsViewModel>();
        InitializeComponent();
    }

    public SettingsViewModel ViewModel
    {
        get;
    }
}