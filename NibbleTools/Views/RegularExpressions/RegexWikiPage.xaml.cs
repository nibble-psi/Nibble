// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using NibbleTools.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class RegexWikiPage : Page
{
    public RegexWikiPage()
    {
        ViewModel = App.GetService<RegexWikiViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public RegexWikiViewModel ViewModel
    {
        get;
        set;
    }

    private void CopyButtonClick(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        var pattern = (string)button.DataContext;
        ViewModel.CopyCommand.Execute(pattern);
    }
}