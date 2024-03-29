// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml.Controls;
using NibbleTools.ViewModels.BitsManipulation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NibbleTools.Pages;

/// <summary>
///     An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class BitShiftPage : Page
{
    public BitShiftPage()
    {
        ViewModel = App.GetService<BitShiftViewModel>();
        DataContext = ViewModel;
        InitializeComponent();
    }

    public BitShiftViewModel ViewModel
    {
        get;
        set;
    }
}