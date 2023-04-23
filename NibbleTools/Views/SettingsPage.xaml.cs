using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;
using Microsoft.Windows.AppLifecycle;

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

    private async void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is not ComboBox {IsLoaded: true})
        {
            return;
        }
        
        await ViewModel.SwitchLanguageCommand.ExecuteAsync((string)e.AddedItems[0]);
        
        AppInstance.Restart("LanguageChanged");
    }
}