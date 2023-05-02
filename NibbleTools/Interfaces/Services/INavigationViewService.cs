using Microsoft.UI.Xaml.Controls;

namespace NibbleTools.Interfaces.Services;

public interface INavigationViewService
{
    IList<object>? MenuItems
    {
        get;
    }
    
    IList<NavigationViewItem> NavigationViewItems
    {
        get;
    }

    object? SettingsItem
    {
        get;
    }

    void Initialize(NavigationView navigationView);

    void UnregisterEvents();

    NavigationViewItem? GetSelectedItem(Type pageType);
}