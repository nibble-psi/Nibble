using System.Diagnostics.CodeAnalysis;
using Microsoft.UI.Xaml.Controls;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.Services;
using NibbleTools.ViewModels;

namespace NibbleTools.Services;

public class NavigationViewService : INavigationViewService
{
    private readonly INavigationService _navigationService;

    private readonly IPageService _pageService;

    private NavigationView? _navigationView;

    public NavigationViewService(INavigationService navigationService, IPageService pageService)
    {
        _navigationService = navigationService;
        _pageService = pageService;
        NavigationViewItems = new List<NavigationViewItem>();
    }

    public IList<object>? MenuItems => _navigationView?.MenuItems;

    public IList<NavigationViewItem> NavigationViewItems
    {
        get;
        private set;
    }


    public object? SettingsItem => _navigationView?.SettingsItem;

    [MemberNotNull(nameof(_navigationView))]
    public void Initialize(NavigationView navigationView)
    {
        _navigationView = navigationView;
        _navigationView.BackRequested += OnBackRequested;
        _navigationView.ItemInvoked += OnItemInvoked;

        NavigationViewItems = GetNavigationViewItems();
    }

    public void UnregisterEvents()
    {
        if (_navigationView == null)
        {
            return;
        }

        _navigationView.BackRequested -= OnBackRequested;
        _navigationView.ItemInvoked -= OnItemInvoked;
    }

    public NavigationViewItem? GetSelectedItem(Type pageType)
    {
        if (_navigationView != null)
        {
            return GetSelectedItem(_navigationView.MenuItems, pageType) ??
                   GetSelectedItem(_navigationView.FooterMenuItems, pageType);
        }

        return null;
    }

    private void OnBackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args) =>
        _navigationService.GoBack();

    private void OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
    {
        if (args.IsSettingsInvoked)
        {
            _navigationService.NavigateTo(typeof(SettingsViewModel).FullName!);
        }
        else
        {
            var selectedItem = args.InvokedItemContainer as NavigationViewItem;

            if (selectedItem?.GetValue(NavigationHelper.NavigateToProperty) is string pageKey)
            {
                _navigationService.NavigateTo(pageKey);
            }
        }
    }

    private NavigationViewItem? GetSelectedItem(IEnumerable<object> menuItems, Type pageType)
    {
        foreach (var item in menuItems.OfType<NavigationViewItem>())
        {
            if (IsMenuItemForPageType(item, pageType))
            {
                return item;
            }

            var selectedChild = GetSelectedItem(item.MenuItems, pageType);
            if (selectedChild != null)
            {
                return selectedChild;
            }
        }

        return null;
    }

    private bool IsMenuItemForPageType(NavigationViewItem menuItem, Type sourcePageType)
    {
        if (menuItem.GetValue(NavigationHelper.NavigateToProperty) is string pageKey)
        {
            return _pageService.GetPageType(pageKey) == sourcePageType;
        }

        return false;
    }

    private IList<NavigationViewItem> GetNavigationViewItems(Func<NavigationViewItem, bool>? predicate = null)
    {
        var menuItems = new List<NavigationViewItem>();

        var stack = new Stack<object>(MenuItems ?? Enumerable.Empty<object>());

        while (stack.Count > 0)
        {
            if (stack.Pop() is not NavigationViewItem currentItem)
            {
                continue;
            }

            if (predicate?.Invoke(currentItem) ?? true)
            {
                menuItems.Add(currentItem);
            }

            foreach (var child in currentItem.MenuItems)
            {
                if (child is not null)
                {
                    stack.Push(child);
                }
            }
        }

        return menuItems;
    }
}