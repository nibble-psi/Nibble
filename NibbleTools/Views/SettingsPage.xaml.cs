using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.AppLifecycle;
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