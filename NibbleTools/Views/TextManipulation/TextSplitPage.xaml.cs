// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Views;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class TextSplitPage : Page
{
    public TextSplitPage()
    {
        ViewModel = App.GetService<TextSplitViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public TextSplitViewModel ViewModel
    {
        get;
        set;
    }
}