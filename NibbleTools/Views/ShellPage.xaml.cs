using Windows.System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using NibbleTools.Helpers;
using NibbleTools.Interfaces.Services;
using NibbleTools.Models;
using NibbleTools.ViewModels;

namespace NibbleTools.Views;

public sealed partial class ShellPage
{
    public ShellPage(ShellViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();

        ViewModel.NavigationService.Frame = NavigationFrame;
        ViewModel.NavigationViewService.Initialize(NavigationViewControl);

        App.MainWindow.ExtendsContentIntoTitleBar = true;
        App.MainWindow.SetTitleBar(AppTitleBar);
        App.MainWindow.Activated += MainWindow_Activated;
        AppTitleBarText.Text = "AppDisplayName".GetLocalized();
    }

    public ShellViewModel ViewModel
    {
        get;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        KeyboardAccelerators.Add(BuildKeyboardAccelerator(VirtualKey.Left, VirtualKeyModifiers.Menu));
        KeyboardAccelerators.Add(BuildKeyboardAccelerator(VirtualKey.GoBack));
    }

    private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
    {
        var resource = args.WindowActivationState == WindowActivationState.Deactivated
            ? "WindowCaptionForegroundDisabled"
            : "WindowCaptionForeground";

        AppTitleBarText.Foreground = (SolidColorBrush)Application.Current.Resources[resource];
    }

    private void NavigationViewControl_DisplayModeChanged(NavigationView sender,
        NavigationViewDisplayModeChangedEventArgs args) =>
        AppTitleBar.Margin = new Thickness
        {
            Left = sender.CompactPaneLength * (sender.DisplayMode == NavigationViewDisplayMode.Minimal ? 2 : 1),
            Top = AppTitleBar.Margin.Top,
            Right = AppTitleBar.Margin.Right,
            Bottom = AppTitleBar.Margin.Bottom
        };

    private static KeyboardAccelerator BuildKeyboardAccelerator(VirtualKey key, VirtualKeyModifiers? modifiers = null)
    {
        var keyboardAccelerator = new KeyboardAccelerator {Key = key};

        if (modifiers.HasValue)
        {
            keyboardAccelerator.Modifiers = modifiers.Value;
        }

        keyboardAccelerator.Invoked += OnKeyboardAcceleratorInvoked;

        return keyboardAccelerator;
    }

    private static void OnKeyboardAcceleratorInvoked(KeyboardAccelerator sender,
        KeyboardAcceleratorInvokedEventArgs args)
    {
        var navigationService = App.GetService<INavigationService>();

        var result = navigationService.GoBack();

        args.Handled = result;
    }

    private void OnControlsSearchBoxTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
    {
        if (args.Reason != AutoSuggestionBoxTextChangeReason.UserInput)
        {
            return;
        }


        var querySplit = sender.Text.Split(" ");
        var navigationViewItems = ViewModel.NavigationViewService.NavigationViewItems;


        var suggestions = navigationViewItems
                          .Select(item => new SearchItem(item.Content?.ToString() ?? string.Empty,
                              NavigationHelper.GetNavigateTo(item)))
                          .Where(searchItem => !string.IsNullOrWhiteSpace(searchItem.PageKey))
                          .Select(searchItem => new
                          {
                              searchItem,
                              isMatch = querySplit.All(query =>
                                  searchItem.Title.Contains(query, StringComparison.CurrentCultureIgnoreCase))
                          })
                          .Where(t => t.isMatch)
                          .Select(t => t.searchItem)
                          .OrderByDescending(item =>
                              item.Title.StartsWith(sender.Text,
                                  StringComparison.CurrentCultureIgnoreCase))
                          .ThenBy(item => item.Title)
                          .ToList();


        ControlsSearchBox.ItemsSource = suggestions.Count > 0
            ? suggestions
            : new List<SearchItem>
            {
                new("No results found", string.Empty)
            };
    }


    private void OnControlsSearchBoxQuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
    {
        ControlsSearchBox.Text = string.Empty;

        if (args.ChosenSuggestion is not SearchItem searchItem || string.IsNullOrWhiteSpace(searchItem.PageKey))
        {
            return;
        }

        ViewModel.NavigationService.NavigateTo(searchItem.PageKey);
    }

    private void CtrlF_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
        ControlsSearchBox.Focus(FocusState.Programmatic);
    }
}